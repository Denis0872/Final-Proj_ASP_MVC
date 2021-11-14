using Entity_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_CodeFirst.Controllers
{
    public class EditIAAController : Controller

    {
        private EntityDbContext db = new EntityDbContext();
        static List<infoaboutanimal> animm = new List<infoaboutanimal>();
        // GET: EditIAA
        public ActionResult Index()
        {
            return View(animm);
        }

        // GET: EditIAA/Details/5
        public ActionResult Details(infoaboutanimal i)
        {
            return View(i);
        }

        // GET: EditIAA/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: EditIAA/Create
        [HttpPost]
        public ActionResult Create(infoaboutanimal i)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", i);
                    
                }
                animm.Add(i);
                db.InfAnim.Add(i);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EditIAA/Edit/5
        public ActionResult Edit(int id)
        {
           infoaboutanimal i = new infoaboutanimal();
            foreach (infoaboutanimal iaa in animm)
{
                if (iaa.IdinfoAboutAnimal == id)
                {
                    i.Name = iaa.Name;
                    i.Weight = iaa.Weight;
                    i.Height = iaa.Height;
                    i.Durationin_in__helter_in_monthes = iaa.Durationin_in__helter_in_monthes;
                    i.Deseases = iaa.Deseases;
                    i.SizeAnimal = iaa.SizeAnimal;
                    i.PhotoAnimal = iaa.PhotoAnimal;
                    i.deseases1 = iaa.deseases1;
                }
            }
            return View(i);
        }

        // POST: EditIAA/Edit/5
        [HttpPost]
        public ActionResult Edit(infoaboutanimal i)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", i);
            }
            foreach (infoaboutanimal iaa in animm)
            {
                if (iaa.IdinfoAboutAnimal == i.IdinfoAboutAnimal)
                {
                    iaa.Name = i.Name;
                    iaa.Weight = i.Weight;
                    iaa.Height=i.Height;
                    iaa.Durationin_in__helter_in_monthes=i.Durationin_in__helter_in_monthes  ;
                    iaa.Deseases= i.Deseases ;
                    iaa.SizeAnimal=i.SizeAnimal  ;
                    iaa.PhotoAnimal=i.PhotoAnimal  ;
                    iaa.deseases1 = i.deseases1;
                }
            }

            return RedirectToAction("Index");
            
        }

        // GET: EditIAA/Delete/5
        public ActionResult Delete(int id)
        {
            infoaboutanimal Ainfo = new infoaboutanimal();
            foreach (infoaboutanimal info in animm)
            {
                if (info.IdinfoAboutAnimal == id)
                {
                    Ainfo.Name = info.Name;
                    Ainfo.Weight = info.Weight;
                    Ainfo.Height = info.Height;
                    Ainfo.Durationin_in__helter_in_monthes = info.Durationin_in__helter_in_monthes;
                    Ainfo.Deseases = info.Deseases;
                    Ainfo.SizeAnimal = info.SizeAnimal;
                    Ainfo.PhotoAnimal = info.PhotoAnimal;
                    Ainfo.deseases1 = info.deseases1;
                }
            }
            return View();
        }

        // POST: EditIAA/Delete/5
        [HttpPost]
        public ActionResult Delete(infoaboutanimal i)
        {
            try
            {
                
                foreach (infoaboutanimal p in animm)
                {
                    if (p.IdinfoAboutAnimal == i.IdinfoAboutAnimal)
                    {
                        animm.Remove(p);
                    }
                }
                return RedirectToAction("Index");
            } 
            catch
            {
                return View(i);
            }
        }
    }
}
