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
    public class ProducerController : Controller
    {
        ProducerManager pm = new ProducerManager(new EfProducerDal());
        public IActionResult Index()
        {
            var deger = pm.GetList();
            return View(deger);
        }
        [AllowAnonymous]
        public IActionResult Detail(int id)
        {
            var deger = pm.GetById(id);
            return View(deger);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Producer p)
        {
            if(ModelState.IsValid)
            {
                pm.TAdd(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var deger = pm.GetById(id);
            pm.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var deger = pm.GetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Update(Producer p)
        {
            if (ModelState.IsValid)
            {
                pm.TUpdate(p);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
