using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosquito.CinemaTask.Services.Interfaces
{
    interface IFilmService
    {
        // Get films
        IEnumerable<FilmModel> GetAllFilms(string sortOrder);

        // Add a film
        SuccessType AddFilm(FilmModel model);

        // Edit a Film
        SuccessType EditFilm(FilmModel model);

        // Delete a film
        SuccessType DeleteFilm(int Id);
        FilmModel getEditModel(int id);
    }
}