
using Final_Assignment.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class AddEditContactForm : Form
    {
        private int? contactId;         //Chatgpt


        public AddEditContactForm()
        {
            InitializeComponent();
        }
        public AddEditContactForm(int contactId) : this()
        {
            this.contactId = contactId;
        }

        private void AddEditContactForm_Load(object sender, EventArgs e)
        {
            if (contactId.HasValue)
            {
                LoadContactData(contactId.Value);
            }
        }
        private void LoadContactData(int contactId)
        {
            string query = "SELECT FirstName, LastName, PhoneNumber, Email FROM Contacts WHERE ContactID = @ContactID";

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ContactID", contactId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Set the contact data fields from the reader
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading contact data: " + ex.Message);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled in
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Create a new Contact object to hold the data from the form
            Contact contact = new Contact
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            };

            try
            {
                // If contactId is not null, we are editing an existing contact (UPDATE)
                if (contactId.HasValue)
                {
                    contact.ContactID = contactId.Value; // Set the existing contact ID
                    contact.UpdateContact();  // Call the UpdateContact method to update the record
                }
                else
                {
                    // If contactId is null, we are adding a new contact (INSERT)
                    contact.InsertContact();  // Call the InsertContact method to add a new record
                }

                // If successful, close the form with OK result
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message if anything goes wrong
                MessageBox.Show("Error saving contact: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
