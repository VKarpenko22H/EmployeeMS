using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class RegisterBindingModel
    {
        [Display(Name = "Login")]
        [Required]
        public string Login { get; set; }
        [Display(Name = "Password")]
        [UIHint("Password")]
        [MinLength(6)]
        public string Password { get; set; }
        [Display(Name = "Confirm password")]
        [UIHint("Password")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
