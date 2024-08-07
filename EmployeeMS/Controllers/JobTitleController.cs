using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interfaces;


namespace EmployeeMS.Controllers
{
    public class JobTitleController : Controller
    {
        private readonly IJobTitleService jobTitleService;

        public JobTitleController(IJobTitleService jobTitleService)
        {
            this.jobTitleService = jobTitleService;
        }

        [HttpGet]
        public IActionResult CreateJobTitle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateJobTitle(JobTitle jobTitle)
        {
            jobTitleService.CreateJobTitle(jobTitle);
            return RedirectToAction();
            

        }


        // GET: JobTitleController
        [HttpGet]
        public ActionResult Index()
        {
            var jobTitles = jobTitleService.GetJobTitles().ToList();
            return View(jobTitles);
        }

        

        // GET: JobTitleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        

       

        // POST: JobTitleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobTitleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobTitleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobTitleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobTitleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
