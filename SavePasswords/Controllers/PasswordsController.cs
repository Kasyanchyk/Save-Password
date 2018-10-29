using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SavePasswords.Controllers
{
    [Authorize]
    public class PasswordsController : Controller
    {
        public IActionResult AddPassword()
        {
            return View();
        }
    }
}