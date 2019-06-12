using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosquito.CinemaTask.Repositories.Interfaces
{
    interface IFilmRepository
    {
        // Save film
        SuccessType Save(FilmModel model);

        // Update film
        SuccessType Update(FilmModel model);

        // Delete film
        SuccessType Delete(int Id);

        // Get films
        IEnumerable<FilmModel> AllFilms();
        FilmModel getFilmByID(int id);
    }
}
