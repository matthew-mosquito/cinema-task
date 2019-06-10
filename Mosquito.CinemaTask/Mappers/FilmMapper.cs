using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mosquito.CinemaTask.Mapper
{
    public class FilmMapper
    {

        public IEnumerable<FilmModel> MapSelect(SqlDataReader reader)
        {
            var modelList = new List<FilmModel>();

            while(reader.Read())
            {
                // Instantiate new film model
                FilmModel film = new FilmModel();

                // Assign the properties from the table columns
                film.Name = reader["FilmName"].ToString();
                film.Rating = Convert.ToInt32(reader["Rating"]);
                film.Duration = Convert.ToDouble(reader["Duration"]);

                // Add each film to the model list
                modelList.Add(film);
            }

            return modelList;
        }
    }
}