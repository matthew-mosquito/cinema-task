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
        bool Save(FilmModel model);

        // Update film
        bool Update(FilmModel model);

        // Delete film
        bool Delete(int Id);

        // Get films
        IEnumerable<FilmModel> AllFilms();
    }
}
