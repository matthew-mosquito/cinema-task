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

        public ActionResult Index(SuccessType type = SuccessType.None)
        {
            var model = _filmServices.GetAllFilms();

            if (type == SuccessType.Create)
                ViewBag.Action = "Create";

            else if (type == SuccessType.Delete)
                ViewBag.Action = "Delete";

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FilmModel model)
        {
            SuccessType success = SuccessType.None;

            if (ModelState.IsValid)
                success = _filmServices.AddFilm(model);

            return RedirectToAction("Index", new { type = success });
        }

        [HttpGet]
        public ActionResult Edit(FilmModel model)
        {
            return View(model);
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditPost(FilmModel model)
        {
            SuccessType success = SuccessType.None;

            if (ModelState.IsValid)
                success = _filmServices.EditFilm(model);

            if (success == SuccessType.Edit)
                ViewBag.Success = true;
            else if (success == SuccessType.Failed)
                ViewBag.Success = false;

            return View("Edit", model);
        }

        public ActionResult Delete(int Id)
        {
            SuccessType success = _filmServices.DeleteFilm(Id);

            return RedirectToAction("Index", new {type = success });
        }
    }
}