using DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMS.Models
{
    public class UserModelView
    {

        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-z,A-Z]+$")]
        public string Login { get; set; } = string.Empty;
        [Required]
        [RegularExpression(@"^[a-z,A-Z, 0-9]+$")]
        public string Password { get; set; } = string.Empty;
        [Required]

        public string PasswordConfirm { get; set; } = string.Empty;
        public string PasswordHash { get; set; }
        public static List<User> Users { get; set; } = new List<User>();
    }
}
