/*
 * Title: Assignment - 1 Tic Tac Toe Game
 * Kirtan Patel, Student ID : 100925226
 * 29 Sept 2024
 * This file contains game logic for Tic Tac Toe Game which allows players to track 
 * thier wins, and allows them to reset the game.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASSIGNMENT_1
{
    public partial class frmMain : Form
    {
        #region Form Load Event
        /// <summary>
        /// Initializing the form components and game set up
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            // Initialize game variables
            playerTurn = true; // Assuming Player 1 starts by default

            // Assign click events to game board labels
            Label[] squares = { lblSq1, lblSq2, lblSq3, lblSq4, lblSq5,
                                lblSq6, lblSq7, lblSq8, lblSq9 };

            foreach (Label square in squares)
            {
                square.Click += lblSquare_Click;
            }
        }
        #endregion

        #region Global Variables
        /// <summary>
        /// Decalring Global Variables and Initializing them
        /// </summary>

        private bool playerTurn; // true for Player 1, false for Player 2
        private int player1Wins = 0;
        private int player2Wins = 0;
        private int draws = 0;
        private string player1Symbol;
        private string player2Symbol;
        #endregion      

        #region Determine Player Logic and Validations
        /// <summary>
        /// To check whether the user has entered a valid character or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        private bool ContainsInvalidCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return true; // true if invalid character found
                }
            }
            return false;
        }

        /// <summary>
        /// Validating Names and symbols chosen by players and Start the game as Start button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeterminePlayer_Click(object sender, EventArgs e)
        {
            // Validate Player Names
            if (string.IsNullOrWhiteSpace(txtPlayer1.Text) || string.IsNullOrWhiteSpace(txtPlayer2.Text))
            {
                MessageBox.Show("Please enter names for both players.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPlayer1.Text.Equals(txtPlayer2.Text))
            {
                MessageBox.Show("Player names can not be the Same!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ContainsInvalidCharacters(txtPlayer1.Text) || ContainsInvalidCharacters(txtPlayer2.Text))
            {
                MessageBox.Show("Player names must contain only letters (no numbers or special characters).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that both players have selected a symbol
            if (!rdbP1x.Checked && !rdbP1o.Checked)
            {
                MessageBox.Show("Player 1 must select a symbol (X or O).", "Symbol Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdbP2x.Checked && !rdbP2o.Checked)
            {
                MessageBox.Show("Player 2 must select a symbol (X or O).", "Symbol Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that each player has selected a different symbol
            if ((rdbP1x.Checked && rdbP2x.Checked) || (rdbP1o.Checked && rdbP2o.Checked))
            {
                MessageBox.Show("Both players cannot select the same symbol. One must be 'X' and the other 'O'.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine which player has selected X and O
            player1Symbol = rdbP1x.Checked ? "X" : "O"; // Player 1's symbol
            player2Symbol = rdbP2x.Checked ? "X" : "O"; // Player 2's symbol

            // Randomly decide who goes first
            Random rnd = new Random();
            int firstPlayer = rnd.Next(0, 2); // 0 for Player 1, 1 for Player 2

            if (firstPlayer == 0) // Player 1's turn
            {
                tbxCurrentTurn.Text = $"{txtPlayer1.Text} ({player1Symbol}) goes first";
                playerTurn = true; // Player 1's turn
            }
            else // Player 2's turn
            {
                tbxCurrentTurn.Text = $"{txtPlayer2.Text} ({player2Symbol}) goes first";
                playerTurn = false; // Player 2's turn
            }
            
            btnStart.Visible = false;
        }
        #endregion

        #region Label Square Click Events

        /// <summary>
        /// To plcae respective symbol for each player on label they click and validations on the labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSquare_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;

            // Check if any square is being overwritten
            if (clickedLabel.Text != "")
            {
                MessageBox.Show("This square is already taken. Choose another square.", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Place the symbol on the clicked square based on the current player's turn
            if (playerTurn)
            {
                clickedLabel.Text = player1Symbol;
                clickedLabel.ForeColor = Color.Red;
                tbxCurrentTurn.Text = $"{txtPlayer2.Text} ({player2Symbol})'s turn";
            }
            else
            {
                clickedLabel.Text = player2Symbol;
                clickedLabel.ForeColor = Color.Blue;
                tbxCurrentTurn.Text = $"{txtPlayer1.Text} ({player1Symbol})'s turn";
            }

            // Toggle the player's turn
            playerTurn = !playerTurn;

            // Call a method to check for the winner
            CheckWinner();
        }
        #endregion

        #region Winner Check Logic
        /// <summary>
        /// Check Winner or Draw after every move.
        /// </summary>
        private void CheckWinner()
        { // Source: https://chatgpt.com/c/66eee098-9e5c-8000-a409-77f46e8d91d6
            Label[] squares = { lblSq1, lblSq2, lblSq3,
                        lblSq4, lblSq5, lblSq6,
                        lblSq7, lblSq8, lblSq9 };

            // Check rows for a winner
            for (int i = 0; i < 9; i += 3)
            {
                if (squares[i].Text == squares[i + 1].Text && squares[i + 1].Text == squares[i + 2].Text && squares[i].Text != "")
                {
                    DeclareWinner(squares[i].Text);
                    return;
                }
            }

            // Check columns for a winner
            for (int i = 0; i < 3; i++)
            {
                if (squares[i].Text == squares[i + 3].Text && squares[i + 3].Text == squares[i + 6].Text && squares[i].Text != "")
                {
                    DeclareWinner(squares[i].Text);
                    return;
                }
            }

            // Check diagonals for a winner
            if (squares[0].Text == squares[4].Text && squares[4].Text == squares[8].Text && squares[0].Text != "")
            {
                DeclareWinner(squares[0].Text);
                return;
            }

            if (squares[2].Text == squares[4].Text && squares[4].Text == squares[6].Text && squares[2].Text != "")
            {
                DeclareWinner(squares[2].Text);
                return;
            }

            // Check for a draw (if all squares are filled and no winner)
            bool allFilled = true;
            foreach (Label square in squares)
            {
                if (square.Text == "")
                {
                    allFilled = false;
                    break;
                }
            }

            if (allFilled)
            {
                MessageBox.Show("The game is a draw!!!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                draws++;
            }

            lblP1Score.Text = player1Wins.ToString();
            lblP2Score.Text = player2Wins.ToString();
            lblDraw.Text = draws.ToString(); // Update when there's a draw

        }
        #endregion

        #region Declare Winner
        /// <summary>
        /// Declare the Winner and Show respective scores.
        /// </summary>
        /// <param name="winningSymbol"></param>

        // Method to declare the winner and display the result
        private void DeclareWinner(string winningSymbol)
        {
            string winner;

            lblP1Score.Text = player1Wins.ToString();
            lblP2Score.Text = player2Wins.ToString();
            lblDraw.Text = draws.ToString(); // Update when there's a draw


            if (winningSymbol == player1Symbol)
            {
                winner = txtPlayer1.Text;
                player1Wins++;
                lblP1Score.Text = player1Wins.ToString();
            }
            else
            {
                winner = txtPlayer2.Text;
                player2Wins++;
                lblP2Score.Text = player2Wins.ToString();
            }

            MessageBox.Show($"{winner} wins the game!!", "We Got A Winner!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGame(); // Reset the game for the next round
            lblP1Score.Visible = true; // Set Visible as the game is over!
            lblP2Score.Visible = true; // Set Visible as the game is over!
            lblDraw.Visible = true; // Set Visible as the game is over!
        }
        #endregion

        #region Reset Game Logic
        /// <summary>
        /// Reset the Game after each game.
        /// </summary>

        // Method to reset the game
        private void ResetGame()
        {
            Label[] squares = { lblSq1, lblSq2, lblSq3,
                        lblSq4, lblSq5, lblSq6,
                        lblSq7, lblSq8, lblSq9 };

            foreach (Label square in squares)
            {
                square.Text = "";
            }
            btnStart.Visible = true;

            Random rnd = new Random();
            int firstPlayer = rnd.Next(0, 2); // 0 for Player 1, 1 for Player 2

            if (firstPlayer == 0) // Player 1's turn
            {
                tbxCurrentTurn.Text = $"{txtPlayer1.Text} ({player1Symbol}) goes first";
                playerTurn = true; // Player 1's turn
            }
            else // Player 2's turn
            {
                tbxCurrentTurn.Text = $"{txtPlayer2.Text} ({player2Symbol}) goes first";
                playerTurn = false; // Player 2's turn
            }
        }
        #endregion

        #region Reset Button

        /// <summary>
        /// Reset the game and set the scores to default when Reset is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Reset Button Click Logic
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
            // Reset all the labels, textboxes and radio buttons
            player1Wins = 0;
            player2Wins = 0;
            draws = 0;
            lblP1Score.Text = "0";
            lblP2Score.Text = "0";
            lblDraw.Text = "0"; // Reset draw counter

            txtPlayer1.Text = string.Empty;
            txtPlayer2.Text = string.Empty;

            rdbP1o.Checked = false;
            rdbP1x.Checked = false;
            rdbP2o.Checked = false;
            rdbP2x.Checked = false;
        }
        #endregion

        #region Exit Button Logic

        /// <summary>
        /// To handle Exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Exit Button Logic
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ask the user if they really want to exit the application
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        } 
    }
}