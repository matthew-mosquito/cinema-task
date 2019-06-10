using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Repositories;
using Mosquito.CinemaTask.Repositories.Interfaces;
using Mosquito.CinemaTask.Services.Interfaces;

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

        public IEnumerable<FilmModel> GetAllFilms()
        {
            var allFilms = _filmRepository.AllFilms();

            return allFilms;
        }

        public bool AddFilm(FilmModel model)
        {
            var rowsAdded = _filmRepository.Save(model);

            return rowsAdded;
        }

        public bool EditFilm(FilmModel model)
        {
            var rowsEdited = _filmRepository.Update(model);

            return rowsEdited;
        }

        public bool DeleteFilm(int Id)
        {
            var rowsDeleted = _filmRepository.Delete(Id);

            return true;
        }
    }
}