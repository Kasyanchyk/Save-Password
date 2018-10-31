using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SavePasswords.Models;
using SavePasswords.Models.PasswordsFolder;
using Microsoft.AspNetCore.Identity;

namespace SavePasswords.Controllers
{
    [Authorize]
    public class PasswordsController : Controller
    {
        private string key = "12345678";

        private IPasswordsRepository repository;

        public PasswordsController(IPasswordsRepository repo)
        {
            repository = repo;
        }

        public IActionResult Inex()
        {
            return View();
        }

        public IActionResult AddPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPassword(AddPassword model)
        {
            Password pass = new Password();
            AppUser user = new AppUser();
            

            if (ModelState.IsValid)
            { 
                if(model.Password==model.RepeatPassword)
                {
                    pass.Name = model.Name;
                    pass.IdUser = user.Id;
                    if (model.Url != null)
                        pass.Url = model.Url;
                    if (model.Email != null)
                        pass.Email = model.Email;

                    pass.CryptedPassword = StringCipher.Encrypt(model.Password, key);
                    repository.AddPassword(pass);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(nameof(model.Password),"Invalid user or password");
                }
            }
            return View(model);
        }
    }
}