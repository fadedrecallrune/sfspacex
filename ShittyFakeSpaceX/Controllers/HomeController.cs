using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ShittyFakeSpaceX.Models;

namespace ShittyFakeSpaceX.Controllers
{
    public class HomeController : Controller
    {
        private FlightContext db;
        public HomeController(FlightContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            List<Flight> flights = db.Flights.ToList();
            return View(flights);
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }


    }
}
