using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Repositories;
using Mosquito.CinemaTask.Repositories.Interfaces;
using Mosquito.CinemaTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            throw new NotImplementedException();
        }

        public bool EditFilm(FilmModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFilm(FilmModel model)
        {
            throw new NotImplementedException();
        }
    }
}