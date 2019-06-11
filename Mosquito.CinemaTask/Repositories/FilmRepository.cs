using Mosquito.CinemaTask.Models;
using Mosquito.CinemaTask.Repositories.Interfaces;
using Mosquito.CinemaTask.Mapper;
using Mosquito.CinemaTask.Logger;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System;


namespace Mosquito.CinemaTask.Repositories
{
    public class FilmRepository : IFilmRepository, IDatabase
    {
        FilmLogging logger;
        public FilmRepository()
        {
            logger = new FilmLogging();
        }
        private SqlConnection con;
        private FilmMapper mapper;

        public SqlConnection connection()
        {
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
                try
                {
                    const string query = "SELECT Id, Film, Rating, Duration FROM Films;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataReader result = cmd.ExecuteReader();
                        model = mapper.MapSelectResults(result);
                        return model;
                    }
                }
                catch (Exception ex)
                {
                    logger.WriteLine($"Error retrieving list of all films: {ex.Message}");
                }
            }
            return null;
        }

        public bool Delete(int Id)
        {
            using (var con = connection())
            {
                const string query = "DELETE FROM Films WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Id", Id);
                        int rowsDeleted = cmd.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                            return true;
                    }
                    catch (Exception ex)
                    {
                        logger.WriteLine($"Error deleting film from database: {ex.Message}");
                    }
                }
            }
            return false;
        }

        public bool Save(FilmModel model)
        {
            using (var con = connection())
            {
                try
                {
                    const string query = "INSERT INTO Films (Film, Rating, Duration) VALUES (@Film, @Rating, @Duration)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd = mapper.MapAdd(cmd, model);
                    var rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return true;
                }
                catch ( Exception ex )
                {
                    logger.WriteLine($"Error saving film to database: {ex.Message}");
                }

            }
            return false;
        }

        public bool Update(FilmModel model)
        {
            using (var con = connection())
            {
                try
                {
                    const string query = "UPDATE Films SET Film=@Film, Rating=@Rating, Duration=@Duration WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd = mapper.MapEdit(cmd, model);
                    var rowsEdited = cmd.ExecuteNonQuery();
                    if (rowsEdited > 0)
                        return true;
                }
                catch ( Exception ex )
                {
                    logger.WriteLine($"Error editing film information {ex.Message}");
                }
            }
            return false;
        }
    }
}