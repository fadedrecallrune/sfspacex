using Microsoft.AspNetCore.Mvc;
using ShittyFakeSpaceX.Models;
using System.Collections.Generic;
using System.Linq;


namespace ShittyFakeSpaceX.Controllers
{
    public class TableController : Controller
    {
        private FlightContext db;
        public TableController(FlightContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            List<Flight> flights = db.Flights.ToList();
            return View(flights);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Flight flight)
        {
            if (ModelState.IsValid)
            {
                db.Flights.Add(flight);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(flight);
        }
    }
}
