using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCore.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        UserManager mn = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ApplicationUser p)
        {
            if(ModelState.IsValid)
            {
                p.UserRole = "User";
                mn.TAdd(p);

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
