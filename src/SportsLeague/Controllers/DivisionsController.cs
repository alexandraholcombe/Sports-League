using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsLeague.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsLeague.Controllers
{
    public class DivisionsController : Controller
    {
        private SportsLeagueContext db = new SportsLeagueContext();
        public IActionResult Index()
        {
            return View(db.Divisions.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            ViewBag.Teams = db.Teams.Where(teams => teams.DivisionId == id).ToList();
            return View(thisDivision);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Division division)
        {
            db.Divisions.Add(division);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            return View(thisDivision);
        }

        [HttpPost]
        public IActionResult Edit(Division division)
        {
            db.Entry(division).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            return View(thisDivision);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisDivision = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            db.Divisions.Remove(thisDivision);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
