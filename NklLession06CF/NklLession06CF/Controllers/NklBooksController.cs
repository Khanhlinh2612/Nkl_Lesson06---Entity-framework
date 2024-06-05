using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NklLession06CF.Models;

namespace NklLession06CF.Controllers
{
    public class NklBooksController : Controller
    {
        private NklBookStore db = new NklBookStore();

        // GET: NklBooks
        public ActionResult Index()
        {
            return View(db.NklBooks.ToList());
        }

        // GET: NklBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NklBook nklBook = db.NklBooks.Find(id);
            if (nklBook == null)
            {
                return HttpNotFound();
            }
            return View(nklBook);
        }

        // GET: NklBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NklBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NklId,NklBookId,NklTitle,NklAuthor,NklYear,NklPulisher,NklPicture,NklCategoryId")] NklBook nklBook)
        {
            if (ModelState.IsValid)
            {
                db.NklBooks.Add(nklBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nklBook);
        }

        // GET: NklBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NklBook nklBook = db.NklBooks.Find(id);
            if (nklBook == null)
            {
                return HttpNotFound();
            }
            return View(nklBook);
        }

        // POST: NklBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NklId,NklBookId,NklTitle,NklAuthor,NklYear,NklPulisher,NklPicture,NklCategoryId")] NklBook nklBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nklBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nklBook);
        }

        // GET: NklBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NklBook nklBook = db.NklBooks.Find(id);
            if (nklBook == null)
            {
                return HttpNotFound();
            }
            return View(nklBook);
        }

        // POST: NklBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NklBook nklBook = db.NklBooks.Find(id);
            db.NklBooks.Remove(nklBook);
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
