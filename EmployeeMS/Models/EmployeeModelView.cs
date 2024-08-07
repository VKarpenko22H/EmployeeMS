using DataAccess.Entities;
using Service.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeModelView
    {
        [Required]
        [Display(Name = "Name of Employee")]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int? IPN { get; set; }

        
        public virtual JobTitle JobTitle { get; set; } = new();
    }
}

