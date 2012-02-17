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
    public class EvaluationController : Controller
    {
        private BlugEntities db = new BlugEntities();

        //
        // GET: /Evaluation/

        public ViewResult Index()
        {
            return View(db.Evaluations.ToList());
        }

        //
        // GET: /Evaluation/Details/5

        public ViewResult Details(int id)
        {
            ClassOfferingEvaluation classofferingevaluation = db.Evaluations.Find(id);
            return View(classofferingevaluation);
        }

        //
        // GET: /Evaluation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Evaluation/Create

        [HttpPost]
        public ActionResult Create(ClassOfferingEvaluation classofferingevaluation)
        {
            if (ModelState.IsValid)
            {
                db.Evaluations.Add(classofferingevaluation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(classofferingevaluation);
        }
        
        //
        // GET: /Evaluation/Edit/5
 
        public ActionResult Edit(int id)
        {
            ClassOfferingEvaluation classofferingevaluation = db.Evaluations.Find(id);
            return View(classofferingevaluation);
        }

        //
        // POST: /Evaluation/Edit/5

        [HttpPost]
        public ActionResult Edit(ClassOfferingEvaluation classofferingevaluation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classofferingevaluation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classofferingevaluation);
        }

        //
        // GET: /Evaluation/Delete/5
 
        public ActionResult Delete(int id)
        {
            ClassOfferingEvaluation classofferingevaluation = db.Evaluations.Find(id);
            return View(classofferingevaluation);
        }

        //
        // POST: /Evaluation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ClassOfferingEvaluation classofferingevaluation = db.Evaluations.Find(id);
            db.Evaluations.Remove(classofferingevaluation);
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