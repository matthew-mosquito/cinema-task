using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mosquito.CinemaTask.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(FilmModel model)
        {
            // Invoke Service function for Creating new entries.
            // Return List View
            return View();
        }
    }
}
