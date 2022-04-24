using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCore.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager gm = new GalleryManager(new EfGalleryDal());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var deger = gm.GetList();
            return View(deger);
        }
    }
}
