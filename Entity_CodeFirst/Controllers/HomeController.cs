using Entity_CodeFirst.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_CodeFirst.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        
        private EntityDbContext db = new EntityDbContext();
        
        public ActionResult Index()
        {
            ViewBag.message = "Главная страница";
            return View();
        }

       // [Authorize(Roles = "admin")]
        public ActionResult Roles()
        {
           IList<string> roles = new List<string> { "Роль не определена" };
        ApplicationUserManager userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
        if (user != null)
        roles = userManager.GetRoles(user.Id);
        ViewBag.rol = roles;
        return View();
        }
        public ActionResult About()
        {
           
            ViewBag.message = "Коротко о нашем сайте";
            return View();
        }
        [Authorize(Roles = "shelter")]
        public ActionResult Admin()
        {

            ViewBag.message = "Админка";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "111";

            return View();
        }
        public ActionResult Articles()
        {
            ViewBag.Message = "111";
            return View();
        }
        public ActionResult Reviews()
        {
            ViewBag.Message = "111";
            return View();
        }
        public ActionResult Animals()
        {
            var animals = db.InfAnim.Include(p=>p.deseases1);
            return View(animals.ToList());

        }
        public ActionResult Shelters()
        {
            var shelters = db.Shelt.Include(p=>p.region);
            return View(shelters.ToList());
        }
        public ActionResult Persons()
        {
            var ppl = db.PplInf;
            return View(ppl.ToList());
        }
        public ActionResult Help()
        {
            ViewBag.Message = "помощь нам";
            return View();
        }
        private void GetAnimals()
        {
            var animals = db.InfAnim.ToList<infoaboutanimal>();
            ViewBag.an = animals;
        }
    }
}