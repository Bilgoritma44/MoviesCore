using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCore.ViewComponents.Actor
{
    public class MovieActor:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
