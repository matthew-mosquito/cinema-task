using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Services;
using Mosquito.CinemaTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mosquito.CinemaTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFilmService _filmServices;

        public HomeController()
        {
            _filmServices = new FilmServices();
        }

        // GET: Default
        public ActionResult Index()
        {
            // return list
            var model = _filmServices.GetAllFilms();

            return View(model);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FilmModel model)
        {
            if (ModelState.IsValid)
            {
                _filmServices.AddFilm(model);
            }

            return RedirectToAction("Index");
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // POST: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Index");
            /*
            try
            {
                // TODO: Add delete logic here

                return View("Index");
            }
            catch
            {
                return View("Index");
            }
            */
        }
    }
}