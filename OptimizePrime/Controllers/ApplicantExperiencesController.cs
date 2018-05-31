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
    public class ApplicantExperiencesController : Controller
    {
        private InvestecGradDBEntities1 db = new InvestecGradDBEntities1();

        // GET: ApplicantExperiences
        public ActionResult Index()
        {
            var applicantExperiences = db.ApplicantExperiences.Include(a => a.Applicant);
            return View(applicantExperiences.ToList());
        }

        // GET: ApplicantExperiences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantExperience applicantExperience = db.ApplicantExperiences.Find(id);
            if (applicantExperience == null)
            {
                return HttpNotFound();
            }
            return View(applicantExperience);
        }

        // GET: ApplicantExperiences/Create
        public ActionResult Create()
        {
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name");
            return View();
        }

        // POST: ApplicantExperiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantExperienceID,HighestQualification,YearsOfExperience,ApplicantID")] ApplicantExperience applicantExperience)
        {
            if (ModelState.IsValid)
            {
                db.ApplicantExperiences.Add(applicantExperience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantExperience.ApplicantID);
            return View(applicantExperience);
        }

        // GET: ApplicantExperiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantExperience applicantExperience = db.ApplicantExperiences.Find(id);
            if (applicantExperience == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantExperience.ApplicantID);
            return View(applicantExperience);
        }

        // POST: ApplicantExperiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicantExperienceID,HighestQualification,YearsOfExperience,ApplicantID")] ApplicantExperience applicantExperience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicantExperience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", applicantExperience.ApplicantID);
            return View(applicantExperience);
        }

        // GET: ApplicantExperiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantExperience applicantExperience = db.ApplicantExperiences.Find(id);
            if (applicantExperience == null)
            {
                return HttpNotFound();
            }
            return View(applicantExperience);
        }

        // POST: ApplicantExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicantExperience applicantExperience = db.ApplicantExperiences.Find(id);
            db.ApplicantExperiences.Remove(applicantExperience);
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
