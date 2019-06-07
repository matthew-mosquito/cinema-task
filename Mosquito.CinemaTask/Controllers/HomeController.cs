﻿using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mosquito.CinemaTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Invoke service function to get list
            // Return List to the view
            return View();
        }

        [HttpPost]
        public ActionResult Delete(FilmModel model)
        {
            // Invoke Service Function to Delete record
            // Return Index
            return View();
        }
    }
}