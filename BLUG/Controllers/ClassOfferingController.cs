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
    public class ClassOfferingController : Controller
    {
        private BlugEntities db = new BlugEntities();

        //
        // GET: /ClassOffering/

        public ViewResult Index()
        {
            var classofferings = db.ClassOfferings.Include(c => c.Vendor).Include(c => c.Instructor).Include(c => c.Location).Include(c => c.Course);
            return View(classofferings.ToList());
        }

        //
        // GET: /ClassOffering/Details/5

        public ViewResult Details(int id)
        {
            ClassOffering classoffering = db.ClassOfferings.Find(id);
            return View(classoffering);
        }

        //
        // GET: /ClassOffering/Create

        public ActionResult Create()
        {
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "Name");
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "Name");
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Name");
            return View();
        } 

        //
        // POST: /ClassOffering/Create

        [HttpPost]
        public ActionResult Create(ClassOffering classoffering)
        {
            if (ModelState.IsValid)
            {
                db.ClassOfferings.Add(classoffering);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "Name", classoffering.VendorId);
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "Name", classoffering.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", classoffering.LocationId);
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Name", classoffering.CourseId);
            return View(classoffering);
        }
        
        //
        // GET: /ClassOffering/Edit/5
 
        public ActionResult Edit(int id)
        {
            ClassOffering classoffering = db.ClassOfferings.Find(id);
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "Name", classoffering.VendorId);
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "Name", classoffering.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", classoffering.LocationId);
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Name", classoffering.CourseId);
            return View(classoffering);
        }

        //
        // POST: /ClassOffering/Edit/5

        [HttpPost]
        public ActionResult Edit(ClassOffering classoffering)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classoffering).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "Name", classoffering.VendorId);
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "Name", classoffering.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", classoffering.LocationId);
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Name", classoffering.CourseId);
            return View(classoffering);
        }

        //
        // GET: /ClassOffering/Delete/5
 
        public ActionResult Delete(int id)
        {
            ClassOffering classoffering = db.ClassOfferings.Find(id);
            return View(classoffering);
        }

        //
        // POST: /ClassOffering/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ClassOffering classoffering = db.ClassOfferings.Find(id);
            db.ClassOfferings.Remove(classoffering);
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