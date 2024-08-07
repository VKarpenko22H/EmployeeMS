using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interfaces;
using Service.Models;
using System.Data;
using DataAccess;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagementSystem.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            
        }


        [HttpGet]
        public IActionResult Index()
        {
            var employees = employeeService.GetEmployees().ToList();
          
            return View(employees);
        }

        
        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            employeeService.CreateEmployee(employee);
            return RedirectToAction();
            

        }

        [HttpGet]
        public IActionResult UpdateEmployee()
        {
            return View();
        }


        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            
            employeeService.UpdateEmployee(employee);
            return RedirectToAction();


        }


        public ViewResult GetOll()
        {
            return View(new List<EmployeeModel>());
        }


            
    
    }
}

