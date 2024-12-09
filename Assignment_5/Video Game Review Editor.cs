/*
 * Name : Kirtan Patel
 * Title : Video Game Review Editor
 * Purpose : Main Form file for assignment - 5
 * Date : 08 December 2024
 */


using Assignment_5.DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class frmMain : Form
    {
        #region Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load Event

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            DialogResult loginResult = frm.ShowDialog();

            if (loginResult == DialogResult.OK)
            {
                User.LoadUsers();
                LoadGames();
                LoadAllReviews();
                UpdateStatusStrip();
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        #endregion

        #region Helper Methods

        private void UpdateStatusStrip()
        {
            if (User.Session.CurrentUserID > 0)
            {
                toolStripStatusLabel1.Text = $"Logged in as: {User.Session.CurrentUserName} ({User.Session.CurrentUserEmail})";
            }
            else
            {
                MessageBox.Show("Session data is not set!", "Error");
                toolStripStatusLabel1.Text = "No user logged in.";
            }
        }

        private void LoadGames()
        {
            Game.LoadGames();
            dataGridView1.DataSource = Game.Games; // dataGridView1 contains all games.
        }

        private void LoadAllReviews()
        {
            Review.LoadAllReviews();
            dataGridView2.DataSource = Review.Reviews; // dataGridView2 contains all reviews.
        }

        private void LoadReviews(int gameID)
        {
            Review.LoadReviews(gameID);
            dataGridView2.DataSource = null; 
            dataGridView2.DataSource = Review.Reviews;
        }

        #endregion

        #region Button Click Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int gameID = (int)dataGridView1.SelectedRows[0].Cells["GameID"].Value;
                string reviewText = txtReview.Text; 
                
                int rating = 0;
                if (!int.TryParse(txtRating.Text, out rating) || rating <= 0 || rating > 10)
                {
                    MessageBox.Show("Please enter a valid rating between 1 and 10.", "Error");
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(reviewText))
                {
                    MessageBox.Show("Please enter a review text.", "Error");
                    return;
                }
                
                Review newReview = new Review
                {
                    GameID = gameID,
                    ReviewerID = User.Session.CurrentUserID, 
                    ReviewText = reviewText,
                    Rating = rating,
                    ReviewDate = DateTime.Now 
                };

                try
                {
                    newReview.InsertReview();

                    txtReview.Clear();
                    txtRating.Clear();

                    LoadReviews(gameID);

                    MessageBox.Show("Review added successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding review: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a game first.", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int reviewID = (int)dataGridView2.SelectedRows[0].Cells["ReviewID"].Value;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this review?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Review.DeleteReview(reviewID);
                        int gameID = (int)dataGridView1.SelectedRows[0].Cells["GameID"].Value;
                        LoadReviews(gameID);
                        MessageBox.Show("Review deleted successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting review: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review to delete.", "Error");
            }
        }

        #endregion

        #region DataGridView Events

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int gameID = (int)dataGridView1.SelectedRows[0].Cells["GameID"].Value;
                LoadReviews(gameID);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                int reviewID = (int)dataGridView2.SelectedRows[0].Cells["ReviewID"].Value;
                Review selectedReview = Review.Reviews.FirstOrDefault(r => r.ReviewID == reviewID);

                if (selectedReview != null)
                {
                    txtReview.Text = selectedReview.ReviewText;
                    txtRating.Text = selectedReview.Rating.ToString();
                }
            }
            else
            {
                txtReview.Clear();
                txtRating.Clear();
            }
        }

        #endregion

        #region Menu Strip Events

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Video Game Reviews Application \n COSC2100 \nVersion 1.0\nDeveloped by Kirtan Patel", "About");
        }

        #endregion
    }
}
