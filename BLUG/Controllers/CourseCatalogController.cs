using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLUG.Models;
using BLUG;

namespace BLUG.Controllers
{ 
    public class CourseCatalogController : Controller
    {
        private BlugEntities db = new BlugEntities();

        //
        // GET: /CourseCatalog/

        public ViewResult Index()
        {
            return View(db.Courses.ToList());
        }

        //
        // GET: /CourseCatalog/Details/5

        public ViewResult Details(int id)
        {
            Course course = db.Courses.Find(id);
            return View(course);
        }

        //
        // GET: /CourseCatalog/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CourseCatalog/Create

        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(course);
        }
        
        //
        // GET: /CourseCatalog/Edit/5
 
        public ActionResult Edit(int id)
        {
            Course course = db.Courses.Find(id);
            return View(course);
        }

        //
        // POST: /CourseCatalog/Edit/5

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        //
        // GET: /CourseCatalog/Delete/5
 
        public ActionResult Delete(int id)
        {
            Course course = db.Courses.Find(id);
            return View(course);
        }

        //
        // POST: /CourseCatalog/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}