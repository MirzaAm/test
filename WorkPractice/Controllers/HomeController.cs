using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkPractice.Models;

namespace WorkPractice.Controllers
{
    public class HomeController : Controller
    {

        WorkPracticeEntities db = new WorkPracticeEntities();

        // GET: /User/
        public ActionResult Index()
        {
            return View(db.EmpAllowances.ToList());
        }

        // GET: /User/Edit
       [HttpGet]
        public ActionResult EditPartial(int pp)
        {
            EmpAllowance empallowance = db.EmpAllowances.Find(pp);
            return PartialView(empallowance);
        }
       // POST: /User/Edit
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult EditPartial(EmpAllowance empallowance)
       {
           if (ModelState.IsValid)
           {
               db.Entry(empallowance).State = EntityState.Modified;
               db.SaveChanges();
               TempData["Msg"] = "Data has been updated succeessfully";
               return RedirectToAction("Index");
                          }
           return PartialView(empallowance);
           
       }
    }
}

//        // GET: /User/Details/5
       

//        // GET: /User/Create
//        public ActionResult Create()
//        {
//            return PartialView("Create");
//        }

//        // POST: /User/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(EmpAllowance empallowance, string Command)
//        {
//            if (ModelState.IsValid)
//            {
//                db.EmpAllowances.Add(empallowance);
//                db.SaveChanges();
//                TempData["Msg"] = "Data has been saved succeessfully";
//                return RedirectToAction("Index");
//            }

//            return View(empallowance);
//        }

//        //// GET: /User/Edit/5
//        //public ActionResult Edit(int id=0)
//        //{
//        //    EmpAllowance empallowance = db.EmpAllowances.Find(id);
//        //    if (empallowance == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(empallowance);
//        //    //return RedirectToAction("Index");
//        //}

//        // GET: /User/Edit/Ajax
//        [HttpPost]
//        public ActionResult Lyubomir()
//        {
//            return RedirectToAction("Index");
//        }
//        public ActionResult Edit(string pp)
//        {
//            EmpAllowance ea = new EmpAllowance();
//            int bb = Convert.ToInt32(pp);
//            ea = db.EmpAllowances.First( cc => cc.AllowanceID == bb);
//            return PartialView("EditPartial", ea);
//        }

//        // POST: /User/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(EmpAllowance empallowance)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(empallowance).State = EntityState.Modified;
//                db.SaveChanges();
//                TempData["Msg"] = "Data has been updated succeessfully";
//                return RedirectToAction("Index");
//            }
//            return View(empallowance);
//        }


//        // GET: /User/Delete/5
//        public ActionResult Delete(int id)
//        {
//            EmpAllowance empallowance = db.EmpAllowances.Find(id);
//            db.EmpAllowances.Remove(empallowance);
//            db.SaveChanges();
//            TempData["Msg"] = "Data has been deleted succeessfully";
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            db.Dispose();
//            base.Dispose(disposing);
//        }
//    }
//}

        
        // //GET: /Home/
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        //[HttpGet]
        //public ActionResult Editpartial(string pp)
        //{
        //    EmpAllowance ea = new EmpAllowance();
        //    int bb = Convert.ToInt32(pp);
        //    ea = db.EmpAllowances.First( cc => cc.AllowanceID == bb);
        //    return PartialView("Editpartial", ea);
        //}
        //public ActionResult CreatePartial(string aa)
        //{
        //    EmpAllowance ea = new EmpAllowance();
        //    int bb = Convert.ToInt32(aa);
        //    ea = db.EmpAllowances.First(cc => cc.AllowanceID == bb);
        //    return PartialView("CreatePartial", ea);
        //}
        //public ActionResult DeletePartial(string aa)
        //{
        //    EmpAllowance ea = new EmpAllowance();
        //    int bb = Convert.ToInt32(aa);
        //    ea = db.EmpAllowances.First(cc => cc.AllowanceID == bb);
        //    return PartialView("DeletePartial", ea);
        //}
        //public ActionResult DetailsPartial(string aa)
        //{
        //    EmpAllowance ea = new EmpAllowance();
        //    int bb = Convert.ToInt32(aa);
        //    ea = db.EmpAllowances.First(cc => cc.AllowanceID == bb);
        //    return PartialView("DetailsPartial", ea);
        //}
        ////Partial View Rendering
        //public ActionResult ShowPartialView()
        //{
        //    return PartialView("PartialView");
        //}

        ////// Partial View 1 on Button1 Press
        ////public ActionResult ShowPartial1View()
        ////{
        ////    return PartialView("Partial1");
        ////}

        //////Partial View 2 on Button 2Press
        ////public ActionResult ShowPartial2View()
        ////{
        ////    return PartialView("Partial2");
        ////}
       
      
        
	

//public ActionResult Partial1(string pp)
//        {
//            EmpAllowance ea = new EmpAllowance();
//            int bb = Convert.ToInt32(pp);
//            ea = db.EmpAllowances.First( cc => cc.AllowanceID == bb);
//            return PartialView("Partial1",ea);
//        }
//        public ActionResult Partial2(string aa)
//        {
//            EmpAllowance ea = new EmpAllowance();
//            int bb = Convert.ToInt32(aa);
//            ea = db.EmpAllowances.First(cc => cc.AllowanceID == bb);
//            return PartialView("Partial2",ea);
//        }