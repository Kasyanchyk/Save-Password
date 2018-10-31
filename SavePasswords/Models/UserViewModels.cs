using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavePasswords.Models
{
    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

    }

    public class CreateModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }

    }


    public class AddPassword
    {

        [Required]
        public string Name { get; set; }

        public string Url { get; set; }

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string RepeatPassword { get; set; }

        public string ErrorMessage { get; set; }
    }
}
