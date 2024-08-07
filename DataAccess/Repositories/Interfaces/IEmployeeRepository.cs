using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;

namespace DataAccess.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
       

        IEnumerable<Employee> GetFullEmployees();
        IEnumerable<Employee> CreateEmployee(Employee employee);
        IEnumerable<Employee> UpdateEmployee(Employee employee);
        IEnumerable<Employee> RemoveEmployee(Employee employee);

    }
}

