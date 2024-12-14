/*
 * Name : Kirtan Patel
 * Title : Contact Class
 * Purpose : Contact Class file for assignment - 5
 * Date : 08 December 2024
 */


using Final_Assignment.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Final_Assignment
{
    public class Contact
    {
        #region Fields and Properties

        public static List<Contact> Contacts = new List<Contact>();

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        #endregion

        #region Constructors

        public Contact() { }

        public Contact(int contactID, string firstName, string lastName, string phoneNumber, string email)
        {
            ContactID = contactID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        #endregion

        #region Data Loading Methods

        public static void LoadContacts()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Contacts", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Contacts.Add(new Contact(
                            (int)reader["ContactID"],
                            reader["FirstName"].ToString(),
                            reader["LastName"].ToString(),
                            reader["PhoneNumber"].ToString(),
                            reader["Email"].ToString()
                        ));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading contacts: " + ex.Message);
                }
            }
        }

        #endregion

        #region CRUD Operations

        public void InsertContact()
        {
            this.ContactID = GetContactID(); // Get the next available ContactID

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spInsertNewContact", // Assuming you have a stored procedure for inserting contacts
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@ContactID", ContactID);
                    command.Parameters.AddWithValue("@FirstName", FirstName); // Example, adjust to actual Contact properties
                    command.Parameters.AddWithValue("@LastName", LastName);   // Example
                    command.Parameters.AddWithValue("Email", Email);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);         // Example
                                                                              // Add other parameters as needed

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting contact: " + ex.Message);
                }
            }
        }


        public void UpdateContact()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "spUpdateContact",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@ContactID", ContactID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@Email", Email);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating contact: " + ex.Message);
                }
            }
        }

        public static Contact GetContact(int contactID)
        {
            string sql = "SELECT * FROM Contacts WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ContactID", contactID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Contact(
                            (int)reader["ContactID"],
                            reader["FirstName"].ToString(),
                            reader["LastName"].ToString(),
                            reader["PhoneNumber"].ToString(),
                            reader["Email"].ToString()
                        );
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving contact: " + ex.Message);
                }
            }
        }

        public static int GetContactID()
        {
            int maxContactID = 0;

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(ContactID), 0) FROM Contacts", connection);
                    maxContactID = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching max ContactID: " + ex.Message);
                }
            }

            return maxContactID + 1;
        }


        #endregion

        #region Validation and Utility Methods

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Ensure it's a 10-digit numeric value
            return !string.IsNullOrEmpty(phoneNumber) &&
                   phoneNumber.Length == 10 &&
                   phoneNumber.All(char.IsDigit);
        }

        public static bool ValidateEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");  // Validates email format
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {PhoneNumber} ({Email})";
        }

        #endregion
    }
}
