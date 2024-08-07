using AutoMapper;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Service.Interfaces;
using Service.Models;
using System.Net;
using System.Text.RegularExpressions;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repository;
        private readonly IMapper mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            repository = employeeRepository;
            this.mapper = mapper;
        }

        public IEnumerable<EmployeeModel> UpdateEmployee(Employee employee)
        {
            var dbEmployees = repository.UpdateEmployee(employee);
            return mapper.Map<IEnumerable<EmployeeModel>>(dbEmployees);


        }
        public IEnumerable<EmployeeModel> RemoveEmployee(Employee employee)
        {
            var dbEmployees = repository.RemoveEmployee(employee);
            return mapper.Map<IEnumerable<EmployeeModel>>(dbEmployees);
        }

        public IEnumerable<EmployeeModel> CreateEmployee(Employee employee)
        {
            var dbEmployees = repository.CreateEmployee(employee);
            return mapper.Map<IEnumerable<EmployeeModel>>(dbEmployees);
        }

        


        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var dbEmployees = repository.GetAll();
            return mapper.Map<IEnumerable<EmployeeModel>>(dbEmployees);

            
        }

      
    }
}

