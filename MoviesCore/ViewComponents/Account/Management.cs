using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCore.ViewComponents.Account
{
    public class Management:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var userrole = c.ApplicationUsers.Where(x => x.Email == usermail).Select(y => y.UserRole).FirstOrDefault();
            ViewBag.v2 = userrole;
            return View();
        }
    }
}
