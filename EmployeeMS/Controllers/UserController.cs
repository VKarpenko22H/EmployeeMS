using DataAccess.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interfaces;
using Service.Models;
using System.Security.Claims;
using Service.Configuration;


namespace EmployeeMS.Controllers
{
    public class UserController : Controller
    {


        private readonly IUserService userService;
        //private readonly IJobTitleService jobTitleService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
            //this.jobTitleService = jobTitleService;
        }
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Report()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegisterBindingModel userModel)
        {
            if (ModelState.IsValid)
            {
                var userAlreadyExists = UserService.UserModels.Any(x => x.Login == userModel.Login);
                if (userAlreadyExists)
                {
                    ModelState.AddModelError(nameof(userModel.Login), "Login is already in use");
                    return View(userModel);
                }
                var newUserModel = new UserModel()
                {

                    Login = userModel.Login,
                    PasswordHash = PasswordHasher.HashPassword(userModel.Password)
                };
                UserService.UserModels.Add(newUserModel);
                return RedirectToAction("Registration_Authorization", "Home");
            }
            else
            {
                return View(userModel);
            }
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginBindingModel model)
        {
            var serviceModel = model.ToServiceModel();

            if (ModelState.IsValid)
            {
                var userOrNull = UserService.UserModels.FirstOrDefault(x => x.Login == model.Login);
                if (userOrNull is UserModel userModel)
                {
                    var isCorrectPassword = PasswordHasher.IsCorrectPassword(userModel, model.Password);
                    if (isCorrectPassword)
                    {
                        await SignInAsync(userModel);
                        return RedirectToAction("Account", "User");
                    }
                }
                ModelState.AddModelError("", "Wrong login or password");
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private async Task SignInAsync(UserModel userModel)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userModel.Login),
                new Claim(ClaimTypes.Role, "User"),
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
        }

        public IActionResult Complete()
        {
            ViewBag.Username = User.Identity.Name;
            return View();
        }



        public IActionResult Account()
        {
            return View();
        }
    }

    //    [HttpPost]
    //    public IActionResult Registration(User user)
    //    {
    //        userService.CreateUser(user);
    //        return RedirectToAction();


    //}




    //[HttpGet]
    //    public IActionResult Authorization()
    //    {
    //        return View();
    //    }
    //    [HttpGet]
    //    public IActionResult Authorization(User user)


    //    {
    //        userService.CreateUser(user);
    //        return RedirectToAction();

    //    }

    //    // GET: UsersController/Details/5
    //    public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

    //    // GET: UsersController/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: UsersController/Create
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create(IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: UsersController/Edit/5
    //    public ActionResult Edit(int id)
    //    {
    //        return View();
    //    }

    //    // POST: UsersController/Edit/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: UsersController/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        return View();
    //    }

    //    // POST: UsersController/Delete/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Delete(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }
}

