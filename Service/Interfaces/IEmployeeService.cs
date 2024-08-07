using DataAccess.Entities;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEmployeeService
    {
       

        IEnumerable<EmployeeModel> GetEmployees();
        IEnumerable<EmployeeModel> CreateEmployee(Employee employee);
        IEnumerable<EmployeeModel> UpdateEmployee(Employee employee);
        IEnumerable<EmployeeModel> RemoveEmployee(Employee employee);
    }
}

