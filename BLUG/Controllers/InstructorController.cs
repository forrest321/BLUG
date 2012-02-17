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
    public class InstructorController : Controller
    {
        private BlugEntities db = new BlugEntities();

        //
        // GET: /Instructor/

        public ViewResult Index()
        {
            return View(db.Instructors.ToList());
        }

        //
        // GET: /Instructor/Details/5

        public ViewResult Details(int id)
        {
            Instructor instructor = db.Instructors.Find(id);
            return View(instructor);
        }

        //
        // GET: /Instructor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Instructor/Create

        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.Instructors.Add(instructor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(instructor);
        }
        
        //
        // GET: /Instructor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Instructor instructor = db.Instructors.Find(id);
            return View(instructor);
        }

        //
        // POST: /Instructor/Edit/5

        [HttpPost]
        public ActionResult Edit(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instructor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instructor);
        }

        //
        // GET: /Instructor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Instructor instructor = db.Instructors.Find(id);
            return View(instructor);
        }

        //
        // POST: /Instructor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Instructor instructor = db.Instructors.Find(id);
            db.Instructors.Remove(instructor);
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