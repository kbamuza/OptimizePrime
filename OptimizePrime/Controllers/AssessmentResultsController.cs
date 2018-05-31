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
    public class AssessmentResultsController : Controller
    {
        private InvestecGradDBEntities1 db = new InvestecGradDBEntities1();

        // GET: AssessmentResults
        public ActionResult Index()
        {
            var assessmentResults = db.AssessmentResults.Include(a => a.Applicant);
            return View(assessmentResults.ToList());
        }

        // GET: AssessmentResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssessmentResult assessmentResult = db.AssessmentResults.Find(id);
            if (assessmentResult == null)
            {
                return HttpNotFound();
            }
            return View(assessmentResult);
        }

        // GET: AssessmentResults/Create
        public ActionResult Create()
        {
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name");
            return View();
        }

        // POST: AssessmentResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssessmentID,PersonalityTestResult,CognitiveTestResult,ApplicantID")] AssessmentResult assessmentResult)
        {
            if (ModelState.IsValid)
            {
                db.AssessmentResults.Add(assessmentResult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", assessmentResult.ApplicantID);
            return View(assessmentResult);
        }

        // GET: AssessmentResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssessmentResult assessmentResult = db.AssessmentResults.Find(id);
            if (assessmentResult == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", assessmentResult.ApplicantID);
            return View(assessmentResult);
        }

        // POST: AssessmentResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssessmentID,PersonalityTestResult,CognitiveTestResult,ApplicantID")] AssessmentResult assessmentResult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assessmentResult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicantID = new SelectList(db.Applicants, "ApplicantID", "Name", assessmentResult.ApplicantID);
            return View(assessmentResult);
        }

        // GET: AssessmentResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssessmentResult assessmentResult = db.AssessmentResults.Find(id);
            if (assessmentResult == null)
            {
                return HttpNotFound();
            }
            return View(assessmentResult);
        }

        // POST: AssessmentResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssessmentResult assessmentResult = db.AssessmentResults.Find(id);
            db.AssessmentResults.Remove(assessmentResult);
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
