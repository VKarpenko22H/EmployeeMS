using DataAccess.Entities;
using EmployeeMS.Models;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using Service.Models;

namespace EmployeeMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }
       
        


        public IActionResult Registration_Authorization()
        {
            return View();
        }


        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
