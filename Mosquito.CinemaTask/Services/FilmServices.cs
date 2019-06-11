using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Repositories;
using Mosquito.CinemaTask.Repositories.Interfaces;
using Mosquito.CinemaTask.Services.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Mosquito.CinemaTask.Services
{
    public class FilmServices : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmServices()
        {
            _filmRepository = new FilmRepository();
        }

        public IEnumerable<FilmModel> GetAllFilms(string sortOrder = "none")
        {
            IEnumerable<FilmModel> allFilms;

            if (sortOrder == "Ascending")
            {
                allFilms = from film in _filmRepository.AllFilms()
                           orderby film.Name ascending
                           select film;
            }

            else if (sortOrder == "Descending")
            {
                allFilms = from film in _filmRepository.AllFilms()
                           orderby film.Name descending
                           select film;
            }

            else
                allFilms = _filmRepository.AllFilms();

            return allFilms;
        }

        public SuccessType AddFilm(FilmModel model)
        {
            SuccessType rowsAdded = _filmRepository.Save(model);

            return rowsAdded;
        }

        public SuccessType EditFilm(FilmModel model)
        {
            SuccessType rowsEdited = _filmRepository.Update(model);

            return rowsEdited;
        }

        public SuccessType DeleteFilm(int Id)
        {
            SuccessType rowsDeleted = _filmRepository.Delete(Id);

            return rowsDeleted;
        }
    }
}