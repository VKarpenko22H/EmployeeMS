using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class JobTitleModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Department { get; set; }
        public string? Subdivision { get; set; }
        public string? Group { get; set; }

        public decimal Salary { get; set; } = 0;

        //public List<JobTitle> JobTitles { get; set; } = new ();
        public List<Employee> Employees { get; set; } = new();




    }
}
