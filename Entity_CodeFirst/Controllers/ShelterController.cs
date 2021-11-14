using Entity_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_CodeFirst.Controllers
{
    public class ShelterController : Controller
    {
        static List<shelter> shelt = new List<shelter>();
        private EntityDbContext db = new EntityDbContext();
        // GET: Shelter
        public ActionResult Index()
        {
            return View(shelt);
        }

        // GET: Shelter/Details/5
        public ActionResult Details(shelter sh)
        {
            return View(sh);
        }

        // GET: Shelter/Create
        [Authorize(Roles = "shelter")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shelter/Create
        [HttpPost]
        public ActionResult Create(shelter sh)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", sh);
                }
                shelt.Add(sh);
                db.Shelt.Add(sh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        // GET: Shelter/Edit/5
        [Authorize(Roles = "shelter")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shelter/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shelter/Delete/5
        [Authorize(Roles = "shelter")]
        public ActionResult Delete(int id)
        {
            shelter sh = new shelter();
            foreach (shelter pn in shelt)
            {
                if (pn.idshelter == id)
                {
                    sh.Adress = pn.Adress;
                    sh.Phone = pn.Phone;
                    sh.LimitAnimals = pn.LimitAnimals;
                    sh.CountAnimals = pn.CountAnimals;
                    sh.idRegion = pn.idRegion;
                }
            }
            return View(sh);
        }

        // POST: Shelter/Delete/5
        [HttpPost]
        public ActionResult Delete(shelter sh)
        {
            try
            {
  
                foreach (shelter pn in shelt)
                {
                    if (pn.idshelter == sh.idshelter)
                    {
                        shelt.Remove(pn);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(sh);
            }
        }
    }
}
