using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Repositories.Interfaces;
using Mosquito.CinemaTask.Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mosquito.CinemaTask.Repositories
{
    public class FilmRepository : IFilmRepository, IDatabase
    {

        // Get the SQL Connection
        private SqlConnection con;
        // Get the mapper
        private FilmMapper mapper;

        public SqlConnection connection()
        {
            // Instantiate mapping
            mapper = new FilmMapper();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(connectionString);

            return con;
        }
        public IEnumerable<FilmModel> AllFilms()
        {
            IEnumerable<FilmModel> model;

            using (var con = connection())
            {
                const string query = "SELECT Id, FilmName, Rating, Duration FROM Films;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    SqlDataReader result = cmd.ExecuteReader();

                    model = mapper.MapSelect(result);
                }
            }
            return model;
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save(FilmModel model)
        {
            throw new NotImplementedException();
        }

        public bool Update(FilmModel model)
        {
            throw new NotImplementedException();
        }
    }
}