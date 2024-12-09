/*
 * Name : Kirtan Patel
 * Title : Review Class
 * Purpose : Review Class file for assignment - 5
 * Date : 08 December 2024
 */

using Assignment_5.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Assignment_5.DBAL.User;

namespace Assignment_5.DBAL
{
    /// <summary>
    /// Represents a video game review.
    /// </summary>
    public class Review
    {
        #region Properties

        public int ReviewID { get; set; }
        public int GameID { get; set; }
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        // In-memory storage for reviews
        public static List<Review> Reviews = new List<Review>();

        #endregion

        #region Constructors

        public Review() { }

        public Review(int reviewID, int gameID, int reviewerID, int rating, string reviewText, DateTime reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewerID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }

        #endregion

        #region CRUD Operations

        /// <summary>
        /// Inserts a new review into the database.
        /// </summary>
        public void InsertReview()
        {
            ReviewID = GetReviewID(); // Generate unique ReviewID

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spInsertNewReview",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@ReviewID", ReviewID);
                    command.Parameters.AddWithValue("@GameID", GameID);
                    command.Parameters.AddWithValue("@UserID", Session.CurrentUserID); // Current logged-in user
                    command.Parameters.AddWithValue("@Rating", Rating);
                    command.Parameters.AddWithValue("@ReviewText", ReviewText);
                    command.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                    command.ExecuteNonQuery();
                    Reviews.Add(this); // Add to in-memory list
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting review: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Updates an existing review.
        /// </summary>
        public void UpdateReview()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spUpdateReview",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@ReviewID", ReviewID);
                    command.Parameters.AddWithValue("@GameID", GameID);
                    command.Parameters.AddWithValue("@ReviewerID", ReviewerID);
                    command.Parameters.AddWithValue("@Rating", Rating);
                    command.Parameters.AddWithValue("@ReviewText", ReviewText);
                    command.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating review: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Deletes a review by its ID.
        /// </summary>
        public static void DeleteReview(int reviewID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spDeleteReview",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@ReviewID", reviewID);
                    command.ExecuteNonQuery();

                    // Remove from in-memory list
                    Reviews.RemoveAll(r => r.ReviewID == reviewID);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting review: " + ex.Message);
                }
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Fetches the next available ReviewID.
        /// </summary>
        /// <returns>Unique ReviewID</returns>
        public static int GetReviewID()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(ReviewID), 0) FROM Reviews", connection);
                    return (int)command.ExecuteScalar() + 1;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching max ReviewID: " + ex.Message);
                }
            }
        }

        #endregion

        #region Load Methods

        /// <summary>
        /// Loads all reviews for a specific game.
        /// </summary>
        /// <param name="gameID">The GameID to filter reviews by.</param>
        public static void LoadReviews(int gameID)
        {
            Reviews.Clear();
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Reviews WHERE GameID = @GameID", connection);
                    command.Parameters.AddWithValue("@GameID", gameID);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Reviews.Add(new Review(
                            (int)reader["ReviewID"],
                            (int)reader["GameID"],
                            (int)reader["ReviewerID"],
                            (int)reader["Rating"],
                            reader["ReviewText"].ToString(),
                            (DateTime)reader["ReviewDate"]
                        ));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading reviews: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Loads all reviews from the database.
        /// </summary>
        public static void LoadAllReviews()
        {
            Reviews.Clear();
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Reviews", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Reviews.Add(new Review(
                            (int)reader["ReviewID"],
                            (int)reader["GameID"],
                            (int)reader["ReviewerID"],
                            (int)reader["Rating"],
                            reader["ReviewText"].ToString(),
                            (DateTime)reader["ReviewDate"]
                        ));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading all reviews: " + ex.Message);
                }
            }
        }

        #endregion
    }
}
