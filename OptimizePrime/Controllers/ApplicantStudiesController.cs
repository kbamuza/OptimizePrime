using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OptimizePrime;

namespace OptimizePrime.Controllers
{
    public class ApplicantStudiesController : Controller
    {
        private InvestecGradDBEntities1 db = new InvestecGradDBEntities1();

        // GET: ApplicantStudies
        public ActionResult Index()
        {
            var applicantStudies = db.ApplicantStudies.Include(a => a.Applicant);
            return View(applicantStudies.ToList());
        }

        // GET: ApplicantStudies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantStudy applicantStudy = db.ApplicantStudies.Find(id);
            if (applicantStudy == null)
            {
                return HttpNotFound();
            }
            return View(applicantStudy);
        }

        // GET: ApplicantStudies/Create
        public ActionResult Create()
        {
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name");
            return View();
        }

        // POST: ApplicantStudies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantStudiesID,StudiesDescription,StudiesLocation,StudiesDuration,ApplicantID")] ApplicantStudy applicantStudy)
        {
            if (ModelState.IsValid)
            {
                db.ApplicantStudies.Add(applicantStudy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantStudy.ApplicantID);
            return View(applicantStudy);
        }

        // GET: ApplicantStudies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantStudy applicantStudy = db.ApplicantStudies.Find(id);
            if (applicantStudy == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantStudy.ApplicantID);
            return View(applicantStudy);
        }

        // POST: ApplicantStudies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicantStudiesID,StudiesDescription,StudiesLocation,StudiesDuration,ApplicantID")] ApplicantStudy applicantStudy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicantStudy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantStudy.ApplicantID);
            return View(applicantStudy);
        }

        // GET: ApplicantStudies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantStudy applicantStudy = db.ApplicantStudies.Find(id);
            if (applicantStudy == null)
            {
                return HttpNotFound();
            }
            return View(applicantStudy);
        }

        // POST: ApplicantStudies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicantStudy applicantStudy = db.ApplicantStudies.Find(id);
            db.ApplicantStudies.Remove(applicantStudy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
