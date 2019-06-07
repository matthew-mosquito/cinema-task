using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mosquito.CinemaTask.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit
        public ActionResult Index()
        {
            return View();
        }


        // POST: Film Updates
        [HttpPost]
        public ActionResult Edit(FilmModel model)
        {
            // Invoke Service function to edit (Find which one to edit by Id)
            return View();
        }
    }
}