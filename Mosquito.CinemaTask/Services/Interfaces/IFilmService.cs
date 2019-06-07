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
        // Add a film
        bool AddFilm(FilmModel model);

        // Edit a Film
        bool EditFilm(FilmModel model);

        // Delete a film
        bool DeleteFilm(FilmModel model);
    }
}
