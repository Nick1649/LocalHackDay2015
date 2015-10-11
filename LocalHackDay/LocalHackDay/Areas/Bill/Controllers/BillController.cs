using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LocalHackDay.Models;

namespace LocalHackDay.Areas.Bill.Controllers
{
    public class BillController : Controller
    {
        private ChargesDBContext db = new ChargesDBContext();

        // GET: Bill/Bill
        public ActionResult Index()
        {
            return View();
        }

        // GET: 
        public ActionResult Create()
        {
            return View();
        }

        // POST: 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChargeID,Name,Price")] LocalHackDay.Models.Charge charge)
        {
            if (ModelState.IsValid)
            {
                db.Charges.Add(charge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BillID = new SelectList(db.Bills, "BillID", "BillID", charge.BillID);
            return View(charge);
        }
    }
}