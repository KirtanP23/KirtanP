/*
 * Name : Kirtan Patel
 * Title : Game Class
 * Purpose : Game Class file for assignment - 5
 * Date : 08 December 2024
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Assignment_5.Properties;

namespace Assignment_5.DBAL
{
    public class Game
    {
        #region Properties

        public int GameID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        // In-memory storage for games
        public static List<Game> Games = new List<Game>();

        #endregion

        #region Constructors

        public Game() { }

        public Game(int gameID, string title, string genre, DateTime releaseDate)
        {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

        #endregion

        #region Data Loading

        /// <summary>
        /// Loads all games from the database.
        /// </summary>
        public static void LoadGames()
        {
            SqlConnection connection = new SqlConnection(Settings.Default.conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Games",
                    CommandType = System.Data.CommandType.Text
                };

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Games.Add(new Game(
                        (int)reader["GameID"],
                        reader["Title"].ToString(),
                        reader["Genre"].ToString(),
                        (DateTime)reader["ReleaseDate"]
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading games: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
