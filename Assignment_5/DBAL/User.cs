/*
 * Name : Kirtan Patel
 * Title : User Class
 * Purpose : User Class file for assignment - 5
 * Date : 08 December 2024
 */

using Assignment_5.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Assignment_5.DBAL
{
    public class User
    {
        #region Fields and Properties

        public static List<User> Users = new List<User>();

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PassKey { get; set; }

        #endregion

        #region Constructors

        public User() { }

        public User(int userID, string firstName, string lastName, string email, int passKey)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassKey = passKey;
        }

        #endregion

        #region Session Management

       //ChatGPT
        public static class Session
        {
            public static int CurrentUserID { get; set; }
            public static string CurrentUserName { get; set; } 
            public static string CurrentUserEmail { get; set; } 
        }

        #endregion

        #region Data Loading Methods

        public static void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Users.Add(new User(
                            (int)reader["UserID"],
                            reader["FirstName"].ToString(),
                            reader["LastName"].ToString(),
                            reader["Email"].ToString(),
                            (int)reader["PassKey"]
                        ));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading users: " + ex.Message);
                }
            }
        }

        #endregion

        #region CRUD Operations

        public void InsertUser()
        {
            this.UserID = GetUserID(); 

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spInsertNewUser",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@PassKey", PassKey);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting user: " + ex.Message);
                }
            }
        }

        public void UpdateUser()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spUpdateUser",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@PassKey", PassKey);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating user: " + ex.Message);
                }
            }
        }

        public static User GetUser(string email, int passKey)
        {
            string sql = "SELECT * FROM Users WHERE Email = @Email AND PassKey = @PassKey";
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PassKey", passKey);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new User(
                            (int)reader["UserID"],
                            reader["FirstName"].ToString(),
                            reader["LastName"].ToString(),
                            reader["Email"].ToString(),
                            (int)reader["PassKey"]
                        );
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving user: " + ex.Message);
                }
            }
        }

        public static int GetUserID()
        {
            int maxUserID = 0;

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(UserID), 0) FROM Users", connection);
                    maxUserID = (int)command.ExecuteScalar(); 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching max UserID: " + ex.Message);
                }
            }

            return maxUserID + 1;
        }

        #endregion

        #region Validation and Utility Methods

        public static User ValidateLogin(string email, string passKeyInput)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format.");

            if (!int.TryParse(passKeyInput, out int passKey) || passKeyInput.Length != 4)
                throw new ArgumentException("PassKey must be a 4-digit number.");

            string sql = "SELECT * FROM Users WHERE Email = @Email AND PassKey = @PassKey";
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PassKey", passKey);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                       
                        Session.CurrentUserID = (int)reader["UserID"]; 
                        Session.CurrentUserName = $"{reader["FirstName"]} {reader["LastName"]}";
                        Session.CurrentUserEmail = reader["Email"].ToString();

                        return new User(
                            Session.CurrentUserID,
                            reader["FirstName"].ToString(),
                            reader["LastName"].ToString(),
                            Session.CurrentUserEmail,
                            passKey
                        );
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid email or passkey." +ex.Message);
                }
                return null;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }

        #endregion
    }
}