using DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class JobTitleModelView
    {

        [Required]
        [Display(Name = "JobTitle")]
            public string Name { get; set; } = string.Empty;
            public string? Department { get; set; }
            public string? Subdivision { get; set; }
            public string? Group { get; set; }

            public decimal Salary { get; set; } = 0;

            public List<Employee> Employees { get; set; } = new List<Employee>();
            //public List<JobTitle> JobTitles { get; set; } = new();
    }

    
}

