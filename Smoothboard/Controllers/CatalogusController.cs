using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Smoothboard.Models;

namespace Smoothboard.Controllers
{
    public class CatalogusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Catalogus
        public ActionResult Index()
        {
            return View(db.Surfboards.ToList());
        }

        // GET: Catalogus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Surfboard surfboard = db.Surfboards.Find(id);
            if (surfboard == null)
            {
                return HttpNotFound();
            }
            return View(surfboard);
        }

        // GET: Catalogus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Model,Beschrijving,Afbeelding,Verkoopprijs")] Surfboard surfboard)
        {
            if (ModelState.IsValid)
            {
                db.Surfboards.Add(surfboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surfboard);
        }

        // GET: Catalogus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Surfboard surfboard = db.Surfboards.Find(id);
            if (surfboard == null)
            {
                return HttpNotFound();
            }
            return View(surfboard);
        }

        // POST: Catalogus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Model,Beschrijving,Afbeelding,Verkoopprijs")] Surfboard surfboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surfboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(surfboard);
        }

        // GET: Catalogus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Surfboard surfboard = db.Surfboards.Find(id);
            if (surfboard == null)
            {
                return HttpNotFound();
            }
            return View(surfboard);
        }

        // POST: Catalogus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Surfboard surfboard = db.Surfboards.Find(id);
            db.Surfboards.Remove(surfboard);
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
