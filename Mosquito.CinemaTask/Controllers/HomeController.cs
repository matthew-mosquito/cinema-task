using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mosquito.CinemaTask.Controllers
{
    public class HomeController : Controller
    {

        // Index for returning list
        public ActionResult Index()
        {
            // Invoke service function to get list
            // Return List to the view
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(FilmModel model)
        {
            return View();
        }

        // Edit
        [HttpPost]
        public ActionResult Edit(int id, FilmModel model)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // Are you sure you want to delete?
        public ActionResult Delete(FilmModel film)
        {

            // Return the film back to the view to be displayed.
            return View();
        }

        // Method invoked to delete the film
        [HttpPost]
        public ActionResult Delete(int id, FilmModel model)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}