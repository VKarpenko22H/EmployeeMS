using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly StaffContext context;
        public EmployeeRepository(StaffContext staffContext)
        : base(staffContext)
        {
            context = staffContext;
        }

        public IEnumerable<Employee> CreateEmployee(Employee employee)
        {
            //context.Entry(employee).State = EntityState.Added;
            context.Add(employee);
            context.SaveChanges();
            yield return employee;
        }

        public IEnumerable<Employee> UpdateEmployee(Employee employee)
        {


            context.Update(employee);
            context.SaveChanges();
            yield return employee;
        }
        public IEnumerable<Employee> RemoveEmployee(Employee employee)
        {


            context.Remove(employee);
            context.SaveChanges();
            yield return employee;
        }
        public IEnumerable<Employee> GetFullEmployees() => context.Employees.Include(p => p.JobTitle).ToList();

        
    }
}



  