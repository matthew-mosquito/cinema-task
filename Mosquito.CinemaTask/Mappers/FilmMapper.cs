using Mosquito.CinemaTask.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                film.Id = Convert.ToInt32(reader["Id"]);
                film.Name = reader["Film"].ToString();
                film.Rating = Convert.ToInt32(reader["Rating"]);
                film.Duration = Convert.ToDouble(reader["Duration"]);

                // Add each film to the model list
                modelList.Add(film);
            }

            return modelList;
        }

        internal SqlCommand MapAdd(SqlCommand cmd, FilmModel model)
        {
            cmd.Parameters.AddWithValue("@Film", model.Name);
            cmd.Parameters.AddWithValue("@Rating", model.Rating);
            cmd.Parameters.AddWithValue("@Duration", model.Duration);

            return cmd;
        }

        internal SqlCommand MapEdit(SqlCommand cmd, FilmModel model)
        {
            cmd.Parameters.AddWithValue("@Id", model.Id);
            cmd.Parameters.AddWithValue("@Film", model.Name);
            cmd.Parameters.AddWithValue("@Rating", model.Rating);
            cmd.Parameters.AddWithValue("@Duration", model.Duration);

            return cmd;
        }

    }
}