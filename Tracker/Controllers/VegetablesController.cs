using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System.Collections.Generic;
using System.Linq;


namespace Tracker.Controllers
{
    public class VegetablesController : Controller
    {

        private readonly TrackerContext _db;

        public VegetablesController(TrackerContext db)
        {
            _db = db;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Vegetable meat)
        {
            _db.Meats.Add(meat);
            _db.SaveChanges();
            return RedirectToAction("Index", "Orders");
        }
        public ActionResult Details(int id)
        {
            Meat thisMeat = _db.Meats
                                    .FirstOrDefault(meat => meat.MeatId == id);
            return View(thisMeat);
        }

        public ActionResult Edit(int id)
        {
            Meat thisMeat = _db.Meats.FirstOrDefault(meat => meat.MeatId == id);
            return View(thisMeat);
        }

        [HttpPost]
        public ActionResult Edit(Meat meat)
        {
            _db.Meats.Update(meat);
            _db.SaveChanges();
            return RedirectToAction("Index", "Orders");
        }

        public ActionResult Delete(int id)
        {
            Meat thisMeat = _db.Meats.FirstOrDefault(meat => meat.MeatId == id);
            return View(thisMeat);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Meat thisMeat = _db.Meats.FirstOrDefault(meat => meat.MeatId == id);
            _db.Meats.Remove(thisMeat);
            _db.SaveChanges();
            return RedirectToAction("Index", "Orders");
        }
    }
}