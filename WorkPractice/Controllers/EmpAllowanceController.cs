using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkPractice.Models;

namespace WorkPractice.Controllers
{
    public class EmpAllowanceController : Controller
    {
        private WorkPracticeEntities db = new WorkPracticeEntities();

        // GET: /User/
        public ActionResult Index()
        {
            return View(db.EmpAllowances.ToList());
        }

        // GET: /User/Details/5
        public ActionResult Details(int id = 0)
        {
            EmpAllowance empallowance = db.EmpAllowances.Find(id);
            if (empallowance == null)
            {
                return HttpNotFound();
            }
            return View(empallowance);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpAllowance empallowance, string Command)
        {
            if (ModelState.IsValid)
            {
                db.EmpAllowances.Add(empallowance);
                db.SaveChanges();
                TempData["Msg"] = "Data has been saved succeessfully";
                return RedirectToAction("Index");
            }

            return View(empallowance);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int id=0)
        {
            EmpAllowance empallowance = db.EmpAllowances.Find(id);
            if (empallowance == null)
            {
                return HttpNotFound();
            }
            return View(empallowance);
            //return RedirectToAction("Index");
        }

        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpAllowance empallowance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empallowance).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Msg"] = "Data has been updated succeessfully";
                return RedirectToAction("Index");
            }
            return View(empallowance);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            EmpAllowance empallowance = db.EmpAllowances.Find(id);
            db.EmpAllowances.Remove(empallowance);
            db.SaveChanges();
            TempData["Msg"] = "Data has been deleted succeessfully";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
