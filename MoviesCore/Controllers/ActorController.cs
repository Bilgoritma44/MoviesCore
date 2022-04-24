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
    public class ActorController : Controller
    {
        ActorManager cm = new ActorManager(new EfActorDal());
        public IActionResult Index()
        {
            var deger = cm.GetList();
            return View(deger);
        }
        [AllowAnonymous]
        public IActionResult Detail(int id)
        {
            var deger = cm.GetById(id);
            return View(deger);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Actor p)
        {
            if(ModelState.IsValid)
            {
                cm.TAdd(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var deger = cm.GetById(id);
            cm.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var deger = cm.GetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Update(Actor p)
        {
            if(ModelState.IsValid)
            {
                cm.TUpdate(p);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
