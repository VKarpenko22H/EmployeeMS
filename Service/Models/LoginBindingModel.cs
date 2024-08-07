using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class LoginBindingModel
    {
        [Display(Name = "Login")]
        [Required]
        public string Login { get; set; }
        [Display(Name = "Password")]
        [UIHint("Password")]
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
