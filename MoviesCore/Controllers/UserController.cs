using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCore.Controllers
{
    public class UserController : Controller
    {
        Context c = new Context();
        UserManager mn = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var deger = mn.GetList();
            return View(deger);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ApplicationUser p)
        {
            if (ModelState.IsValid)
            {
                mn.TAdd(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var deger = mn.GetById(id);
            mn.TDelete(deger);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var deger = mn.GetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Update(ApplicationUser p)
        {
            if(ModelState.IsValid)
            {
                var usermail = User.Identity.Name;
                var userRole = c.ApplicationUsers.Where(x => x.Email == usermail).Select(y => y.UserRole).FirstOrDefault();
                p.UserRole = userRole;
                mn.TUpdate(p);
                return RedirectToAction("Index", "Movie");
            }
            return View();
        }
        public IActionResult Update2(int id)
        {
            var deger = mn.GetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Update2(ApplicationUser p)
        {
            if (ModelState.IsValid)
            {
                var usermail = User.Identity.Name;
                var userRole = c.ApplicationUsers.Where(x => x.Email == usermail).Select(y => y.UserRole).FirstOrDefault();
                mn.TUpdate(p);
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}
