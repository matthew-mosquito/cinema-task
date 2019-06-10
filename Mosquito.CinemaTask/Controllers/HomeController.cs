using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Services;
using Mosquito.CinemaTask.Services.Interfaces;
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
                _filmServices.AddFilm(model);

            return RedirectToAction("Index");
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int Id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(FilmModel model)
        {
            // TODO: Add update logic here
            if (ModelState.IsValid)
                _filmServices.EditFilm(model);

            return RedirectToAction("Index");
        }

        // POST: Default/Delete/5
        public ActionResult Delete(int Id)
        {
            // Using the Id, we need to delete the field

            _filmServices.DeleteFilm(Id);

            return RedirectToAction("Index");
        }
    }
}