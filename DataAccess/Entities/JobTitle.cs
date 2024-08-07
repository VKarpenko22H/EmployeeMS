using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Department { get; set; }
        public string? Subdivision { get; set; }
        public string? Group { get; set; }

        public decimal Salary { get; set; } = 0;

        //public virtual ICollection<JobTitle> JobTitles { get; set; } = new List<JobTitle>();
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();


        
    }
}

