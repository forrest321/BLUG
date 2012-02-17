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
    public class VendorController : Controller
    {
        private BlugEntities db = new BlugEntities();

        //
        // GET: /Vendor/

        public ViewResult Index()
        {
            return View(db.Vendors.ToList());
        }

        //
        // GET: /Vendor/Details/5

        public ViewResult Details(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            return View(vendor);
        }

        //
        // GET: /Vendor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vendor/Create

        [HttpPost]
        public ActionResult Create(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                db.Vendors.Add(vendor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(vendor);
        }
        
        //
        // GET: /Vendor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            return View(vendor);
        }

        //
        // POST: /Vendor/Edit/5

        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendor);
        }

        //
        // GET: /Vendor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            return View(vendor);
        }

        //
        // POST: /Vendor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Vendor vendor = db.Vendors.Find(id);
            db.Vendors.Remove(vendor);
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