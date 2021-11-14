using Entity_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_CodeFirst.Controllers
{
    public class PersonController : Controller
    {
        static List<peopleinfo> people = new List<peopleinfo>();
        private EntityDbContext db = new EntityDbContext();
        // GET: Person
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(people);
        }

        // GET: Person/Details/5
        public ActionResult Details(peopleinfo p)
        {
            return View(p);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(peopleinfo p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", p);
                }
                people.Add(p);
                db.PplInf.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            peopleinfo p = new peopleinfo();
            foreach (peopleinfo pn in people)
            {
                if (pn.idpeopleInfo == id)
                {
                    p.Name = pn.Name;
                    p.Surname = pn.Surname;
                    p.Address = pn.Address;
                    p.Phone = pn.Phone;
                    p.region = pn.region;
                    p.kindAnimals = pn.kindAnimals;
                    p.kindanimals1 = pn.kindanimals1;
                    p.region = pn.region;
                    p.region1 = pn.region1;
                }
            }
            return View(p);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(peopleinfo p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }
            foreach (peopleinfo pn in people)
            {
                if (pn.idpeopleInfo == p.idpeopleInfo)
                {
                    p.Name = pn.Name;
                    p.Surname = pn.Surname;
                    p.Address = pn.Address;
                    p.Phone = pn.Phone;
                    p.region = pn.region;
                    p.kindAnimals = pn.kindAnimals;
                    p.kindanimals1 = pn.kindanimals1;
                    p.region = pn.region;
                    p.region1 = pn.region1;
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            peopleinfo p = new peopleinfo();
            foreach (peopleinfo pn in people)
            {
                if (pn.idpeopleInfo == id)
                {
                    p.Name = pn.Name;
                    p.Surname = pn.Surname;
                    p.Address = pn.Address;
                    p.Phone = pn.Phone;
                    p.region = pn.region;
                    p.kindAnimals = pn.kindAnimals;
                    p.kindanimals1 = pn.kindanimals1;
                    p.region = pn.region;
                    p.region1 = pn.region1;
                }
            }
            return View(p);
        }
           
        

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(peopleinfo p)
        {
            try
            {
                foreach (peopleinfo pn in people)
                {
                    if (pn.idpeopleInfo == p.idpeopleInfo)
                    {
                        people.Remove(pn);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        }
    }
}
