using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MoviesCore.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class MovieController : Controller
    {
        Context c = new Context();
        MovieManager mn = new MovieManager(new EfMovieDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        CinemaManager mg = new CinemaManager(new EfCinemaDal());
        ProducerManager pm = new ProducerManager(new EfProducerDal());
        ActorManager ac = new ActorManager(new EfActorDal());

        [AllowAnonymous]
        public IActionResult Index(int page=1)
        {
            var usermail = User.Identity.Name;
            var userrole = c.ApplicationUsers.Where(x => x.Email == usermail).Select(y => y.UserRole).FirstOrDefault();
            ViewBag.v2 = userrole;
            var deger = mn.GetListCategory().ToPagedList(page,9);
            return View(deger);
        }
        [AllowAnonymous]
        public IActionResult Detail(int id)
        {
            var usermail = User.Identity.Name;
            var userrole = c.ApplicationUsers.Where(x => x.Email == usermail).Select(y => y.UserRole).FirstOrDefault();
            ViewBag.v2 = userrole;
            var deger=mn.GetListCategoryDetail(id);
            return View(deger);

        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> category=(from x in cm.GetList()
                 select new SelectListItem
                {
                     Text=x.CategoryName,
                     Value=x.CategoryId.ToString()
                    
                }).ToList();
            ViewBag.v1 = category;

            List<SelectListItem> cinema = (from x in mg.GetList()

                                           select new SelectListItem
                                           {
                                               Text=x.CinemaName,
                                               Value=x.CinemaId.ToString()

                                           }).ToList();
            ViewBag.v2 = cinema;

            List<SelectListItem> producer = (from x in pm.GetList()

                                             select new SelectListItem
                                             {
                                                 Text=x.ProducerName,
                                                 Value=x.ProducerId.ToString()

                                             }).ToList();

            ViewBag.v3 = producer;

            List<SelectListItem> actor = (from x in ac.GetList()
                                          select new SelectListItem
                                          {

                                              Text=x.ActorName,
                                              Value=x.ActorId.ToString()

                                          }).ToList();
            ViewBag.v4 = actor;

            

            return View();
        }
        [HttpPost]
        public IActionResult Add(Movie p)
        {
            if(ModelState.IsValid)
            {
                p.MovieCreateDate = DateTime.Now;
                mn.TAdd(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            List<SelectListItem> category = (from x in cm.GetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()

                                             }).ToList();
            ViewBag.v1 = category;

            List<SelectListItem> cinema = (from x in mg.GetList()

                                           select new SelectListItem
                                           {
                                               Text = x.CinemaName,
                                               Value = x.CinemaId.ToString()

                                           }).ToList();
            ViewBag.v2 = cinema;

            List<SelectListItem> producer = (from x in pm.GetList()

                                             select new SelectListItem
                                             {
                                                 Text = x.ProducerName,
                                                 Value = x.ProducerId.ToString()

                                             }).ToList();

            ViewBag.v3 = producer;

            List<SelectListItem> actor = (from x in ac.GetList()
                                          select new SelectListItem
                                          {

                                              Text = x.ActorName,
                                              Value = x.ActorId.ToString()

                                          }).ToList();
            ViewBag.v4 = actor;
            var deger = mn.GetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Update(Movie p)
        {
            if(ModelState.IsValid)
            {
                p.MovieCreateDate = DateTime.Now;
                mn.TUpdate(p);
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
        public PartialViewResult MovieSearch(string p)
        {
            var deger = mn.GetList(p);
            return PartialView(deger);
        }
    }
}
