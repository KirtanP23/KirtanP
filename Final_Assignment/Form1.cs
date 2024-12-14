using Final_Assignment.Properties;
using System;
using System.Collections;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }
        private void LoadContacts()
        {
            // Get the contacts from the database
            DataTable contacts = GetContacts();

            // Set the DataGridView's DataSource to the fetched DataTable
            dgvContacts.DataSource = contacts;

            // Optional: Adjust column widths and formatting
            dgvContacts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private DataTable GetContacts()
        {
            DataTable contactsTable = new DataTable();

            string query = "SELECT * FROM CONTACTS";
            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                
                try
                {
                    // Open the connection
                    connection.Open();
                    
                    // Create a DataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(contactsTable); // Fill the DataTable with the result of the query
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching contacts: " + ex.Message);
                }
            }
            return contactsTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 1)
            {
                // Get the contact ID of the selected row
                int contactId = Convert.ToInt32(dgvContacts.SelectedRows[0].Cells["ContactID"].Value);

                // Retrieve the contact details based on the contact ID
                AddEditContactForm editForm = new AddEditContactForm();
                if (editForm.ShowDialog() == DialogResult.OK)
                { 
                    // Refresh the DataGridView after editing the contact
                    LoadContacts();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 1)
            {
                // Get the contact ID of the selected row
                int contactId = Convert.ToInt32(dgvContacts.SelectedRows[0].Cells["ContactID"].Value);

                // Confirm before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Delete the contact from the database
                    DeleteContact(contactId);

                    // Refresh the DataGridView after deletion
                    LoadContacts();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }
        }

        private void DeleteContact(int contactId)
        {
            // SQL to delete the contact by ID
            string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";

            using (SqlConnection connection = new SqlConnection(Settings.Default.conn))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ContactID", contactId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting contact: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 1)
            {
                // Get the contact ID of the selected row
                var contactIdValue = dgvContacts.SelectedRows[0].Cells["ContactID"].Value;

                // Check if the value is not DBNull or null
                if (contactIdValue != DBNull.Value && contactIdValue != null)
                {
                    // Try to convert the value to an int
                    if (int.TryParse(contactIdValue.ToString(), out int contactId))
                    {
                        // Open the Add/Edit Contact form with the selected contact ID
                        AddEditContactForm editForm = new AddEditContactForm(contactId);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Refresh the DataGridView after updating the contact
                            LoadContacts();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Contact ID. Please select a valid contact to update.");
                    }
                }
                else
                {
                    MessageBox.Show("The Contact ID is null or invalid. Please select a valid contact.");
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }
        }
    }
}


