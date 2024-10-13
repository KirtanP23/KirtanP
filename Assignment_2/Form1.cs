/* *****************************
 * Title:   Battleship Assignment Main Class File
 * Author:  Kirtan Patel
 * Date:    Oct. 13, 2024
 * Purpose: To create application for Battleship game to complete Assignment - 2
 * ***************************** */


using Battleship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class frmBattleShip : Form
    {
        #region Fields
        private int carrierHits = 0;
        private int battleshipHits = 0;
        private int cruiserHits = 0;
        private int submarineHits = 0;
        private int destroyerHits = 0;
        private int totalBoats = 0;
        #endregion

        public frmBattleShip()
        {
            InitializeComponent();
            panWelcome.Visible = true;
            panGame.Visible = false;
            ResetBoard();
        }

        #region Button Garbage References
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnB1_Click(object sender, EventArgs e)
        {

        }

        private void btnC1_Click(object sender, EventArgs e)
        {

        }

        private void btnD1_Click(object sender, EventArgs e)
        {

        }

        private void btnE1_Click(object sender, EventArgs e)
        {

        }

        private void btnF1_Click(object sender, EventArgs e)
        {

        }

        private void btnG1_Click(object sender, EventArgs e)
        {

        }

        private void btnH1_Click(object sender, EventArgs e)
        {

        }

        private void btnI1_Click(object sender, EventArgs e)
        {

        }

        private void btnJ1_Click(object sender, EventArgs e)
        {

        }

        private void btnJ2_Click(object sender, EventArgs e)
        {

        }

        private void btnI2_Click(object sender, EventArgs e)
        {

        }

        private void btnH2_Click(object sender, EventArgs e)
        {

        }

        private void btnG2_Click(object sender, EventArgs e)
        {

        }

        private void btnF2_Click(object sender, EventArgs e)
        {

        }

        private void btnE2_Click(object sender, EventArgs e)
        {

        }

        private void btnD2_Click(object sender, EventArgs e)
        {

        }

        private void btnC2_Click(object sender, EventArgs e)
        {

        }

        private void btnB2_Click(object sender, EventArgs e)
        {

        }

        private void btnA2_Click(object sender, EventArgs e)
        {

        }

        private void btnA3_Click(object sender, EventArgs e)
        {

        }

        private void btnB3_Click(object sender, EventArgs e)
        {

        }

        private void btnC3_Click(object sender, EventArgs e)
        {

        }

        private void btnD3_Click(object sender, EventArgs e)
        {

        }

        private void btnE3_Click(object sender, EventArgs e)
        {

        }

        private void btnF3_Click(object sender, EventArgs e)
        {

        }

        private void btnG3_Click(object sender, EventArgs e)
        {

        }

        private void btnH3_Click(object sender, EventArgs e)
        {

        }

        private void btnI3_Click(object sender, EventArgs e)
        {

        }

        private void btnJ3_Click(object sender, EventArgs e)
        {

        }

        private void btnJ4_Click(object sender, EventArgs e)
        {

        }

        private void btnI4_Click(object sender, EventArgs e)
        {

        }

        private void btnH4_Click(object sender, EventArgs e)
        {

        }

        private void btnG4_Click(object sender, EventArgs e)
        {

        }

        private void btnF4_Click(object sender, EventArgs e)
        {

        }

        private void btnE4_Click(object sender, EventArgs e)
        {

        }

        private void btnD4_Click(object sender, EventArgs e)
        {

        }

        private void btnC4_Click(object sender, EventArgs e)
        {

        }

        private void btnB4_Click(object sender, EventArgs e)
        {

        }

        private void btnA4_Click(object sender, EventArgs e)
        {

        }

        private void btnA5_Click(object sender, EventArgs e)
        {

        }

        private void btnB5_Click(object sender, EventArgs e)
        {

        }

        private void btnC5_Click(object sender, EventArgs e)
        {

        }

        private void btnD5_Click(object sender, EventArgs e)
        {

        }

        private void btnE5_Click(object sender, EventArgs e)
        {

        }

        private void btnF5_Click(object sender, EventArgs e)
        {

        }

        private void btnG5_Click(object sender, EventArgs e)
        {

        }

        private void btnH5_Click(object sender, EventArgs e)
        {

        }

        private void btnI5_Click(object sender, EventArgs e)
        {

        }

        private void btnJ5_Click(object sender, EventArgs e)
        {

        }

        private void btnJ6_Click(object sender, EventArgs e)
        {

        }

        private void btnI6_Click(object sender, EventArgs e)
        {

        }

        private void btnI7_Click(object sender, EventArgs e)
        {

        }

        private void btnJ7_Click(object sender, EventArgs e)
        {

        }

        private void btnJ8_Click(object sender, EventArgs e)
        {

        }

        private void btnI8_Click(object sender, EventArgs e)
        {

        }

        private void btnI9_Click(object sender, EventArgs e)
        {

        }

        private void btnJ9_Click(object sender, EventArgs e)
        {

        }

        private void btnJ10_Click(object sender, EventArgs e)
        {

        }

        private void btnI10_Click(object sender, EventArgs e)
        {

        }

        private void btnH10_Click(object sender, EventArgs e)
        {

        }

        private void btnH9_Click(object sender, EventArgs e)
        {

        }

        private void btnG9_Click(object sender, EventArgs e)
        {

        }

        private void btnG10_Click(object sender, EventArgs e)
        {

        }

        private void btnF10_Click(object sender, EventArgs e)
        {

        }

        private void btnF9_Click(object sender, EventArgs e)
        {

        }

        private void btnE9_Click(object sender, EventArgs e)
        {

        }

        private void btnE10_Click(object sender, EventArgs e)
        {

        }

        private void btnD10_Click(object sender, EventArgs e)
        {

        }

        private void btnD9_Click(object sender, EventArgs e)
        {

        }

        private void btnC9_Click(object sender, EventArgs e)
        {

        }

        private void btnC10_Click(object sender, EventArgs e)
        {

        }

        private void btnB10_Click(object sender, EventArgs e)
        {

        }

        private void btnB9_Click(object sender, EventArgs e)
        {

        }

        private void btnA10_Click(object sender, EventArgs e)
        {

        }

        private void btnA9_Click(object sender, EventArgs e)
        {

        }

        private void btnA8_Click(object sender, EventArgs e)
        {

        }

        private void btnA7_Click(object sender, EventArgs e)
        {

        }

        private void btnA1_Click(object sender, EventArgs e)
        {

        }

        private void btnB8_Click(object sender, EventArgs e)
        {

        }

        private void btnB7_Click(object sender, EventArgs e)
        {

        }

        private void btnC7_Click(object sender, EventArgs e)
        {

        }

        private void btnC8_Click(object sender, EventArgs e)
        {

        }

        private void btnD8_Click(object sender, EventArgs e)
        {

        }

        private void btnD7_Click(object sender, EventArgs e)
        {

        }

        private void btnE7_Click(object sender, EventArgs e)
        {

        }

        private void btnE8_Click(object sender, EventArgs e)
        {

        }

        private void btnF8_Click(object sender, EventArgs e)
        {

        }

        private void btnF7_Click(object sender, EventArgs e)
        {

        }

        private void btnG7_Click(object sender, EventArgs e)
        {

        }

        private void btnG8_Click(object sender, EventArgs e)
        {

        }

        private void btnH8_Click(object sender, EventArgs e)
        {

        }

        private void btnH7_Click(object sender, EventArgs e)
        {

        }

        private void btnH6_Click(object sender, EventArgs e)
        {

        }

        private void btnG6_Click(object sender, EventArgs e)
        {

        }

        private void btnF6_Click(object sender, EventArgs e)
        {

        }

        private void btnE6_Click(object sender, EventArgs e)
        {

        }

        private void btnD6_Click(object sender, EventArgs e)
        {

        }

        private void btnC6_Click(object sender, EventArgs e)
        {

        }

        private void btnB6_Click(object sender, EventArgs e)
        {

        }

        private void btnA6_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Garbage References Label Clicks
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Garbage Reference
        private void pnlAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Garbage Reference
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Game Control Handlers
        /// <summary>
        /// Handles the Start button click event.
        /// Initiates the game and randomizes boat positions.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            panWelcome.Visible = false;
            panGame.Visible = true;
            BS.RandomizeBoats();
        }

        /// <summary>
        /// Handles the New Game button click event.
        /// Resets the game and randomizes new boat positions.
        /// </summary>
        private void NewGame()
        {
            // Reset flag for the new game
            boatsInitialized = false;
            ClearBoard();      // Clear board at the start of a new game
            /*PlaceBoats();      // Call method to place boats*/
            carrierHits = battleshipHits = cruiserHits = submarineHits = destroyerHits = 0;

            boatsInitialized = true;
        }


        /// <summary>
        /// Places boats on the board if they haven't been placed yet.
        /// Randomizes their positions.
        /// </summary>
        private void PlaceBoats()
        {
            // Check if boats have been placed before; if not, place them
            if (!boatsInitialized)
            {
                BS.RandomizeBoats();  // Place boats randomly on the board
                boatsInitialized = true;  // Set flag to true to prevent re-randomizing
            }
        }

        /// <summary>
        /// Clears the game board and resets UI elements to their default state.
        /// </summary>
        private void ClearBoard()
        {
            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
            {
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                {
                    BS.boatPositions[x, y] = BS.Boats.NoBoat;  // Reset boat positions on the grid
                }
            }

            prbBattleShip.Value = 0;
            prbCarrier.Value = 0;
            prbCruiser.Value = 0;
            prbDestroyer.Value = 0;
            prbSubmarine.Value = 0;
            lblTurns.Text = string.Empty;
            turnCount = 0;


            
        }
        /// <summary>
        /// Resets the visual representation of the game board.
        /// Resets button colors for hits and misses.
        /// </summary>
        private void ResetBoard()
        {
            foreach (Control c in panGame.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                {
                    c.BackColor = SystemColors.Control;  // Reset button colors for hits/misses
                }
            }
        }

        /// <summary>
        /// Updates the turn counter and displays the current turn count on the UI.
        /// </summary>
        private void UpdateTurns()
        {
            turnCount++;
            lblTurns.Text = $"Turns: {turnCount}";
        }



        private void UpdateShipProgress(BS.Boats shipType)
        {
            switch (shipType)
            {
                case BS.Boats.Carrier:
                    carrierHits++;
                    prbCarrier.Value = carrierHits;
                    if (carrierHits == 5)
                    {
                        MessageBox.Show("Carrier has been sunk!");
                    }
                    break;
                case BS.Boats.Battleship:
                    battleshipHits++;
                    prbBattleShip.Value = battleshipHits;
                    if (battleshipHits == 4)
                    {
                        MessageBox.Show("Battleship has been sunk!");
                    }
                    break;
                case BS.Boats.Cruiser:
                    cruiserHits++;
                    prbCruiser.Value = cruiserHits;
                    if (cruiserHits == 3)
                    {
                        MessageBox.Show("Cruiser has been sunk!");
                    }
                    break;
                case BS.Boats.Submarine:
                    submarineHits++;
                    prbSubmarine.Value = submarineHits;
                    if (submarineHits == 3)
                    {
                        MessageBox.Show("Submarine has been sunk!");
                    }
                    break;
                case BS.Boats.Destroyer:
                    destroyerHits++;
                    prbDestroyer.Value = destroyerHits;
                    if (destroyerHits == 2)
                    {
                        MessageBox.Show("Destroyer has been sunk!");
                    }
                    break;
            }

            CheckAllBoatsSunk();
        }

        private bool boatsInitialized = true;

        /// <summary>
        /// Displays a specific boat type on the board based on its size.
        /// </summary>
        /// <param name="boatType">The type of boat to display.</param>
        /// <param name="size">The size of the boat.</param>
        private void ShowFullBoats()
        {
            // Ensure that boats are placed before showing (will not re-randomize)
            if (!boatsInitialized)
            {
                MessageBox.Show("Boats have not been initialized. Start a new game.");
                return;
            }

            // Reset the display of boats
            HideAllBoats();

            // Define the sizes for each boat type
            Dictionary<BS.Boats, int> boatSizes = new Dictionary<BS.Boats, int>
    {
            { BS.Boats.Carrier, 5 },
            { BS.Boats.Battleship, 4 },
            { BS.Boats.Cruiser, 3 },
            { BS.Boats.Submarine, 3 },
            { BS.Boats.Destroyer, 2 }
    };
            // referenced from ChatGPT
            // Iterate over the boat types and display their positions
            foreach (var boat in boatSizes)
            {
                BS.Boats boatType = boat.Key;
                List<Point> boatPositions = new List<Point>();

                // Collect the positions of the current boat
                for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
                {
                    for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                    {
                        if (BS.boatPositions[x, y] == boatType)
                        {
                            boatPositions.Add(new Point(x, y));
                        }
                    }
                }

                // Show the boat by setting the corresponding buttons to a color
                foreach (var position in boatPositions)
                {
                    string buttonName = $"btn{(char)(position.X + 'A' - 1)}{position.Y}";
                    Button boatButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (boatButton != null)
                    {
                        boatButton.BackColor = Color.Gray;  // Display the boat parts in gray
                    }
                }
            }
        }


        private void CheckAllBoatsSunk()
        {
            // Total number of boats is 5 (Carrier, Battleship, Cruiser, Submarine, Destroyer)
            // Ensure that boat hits equal the respective sizes of the boats
            int totalHitsToSinkAllBoats = 5 + 4 + 3 + 3 + 2;  // Sum of all boat sizes

            // Check if the sum of hits equals the total required to sink all boats
            int totalHits = carrierHits + battleshipHits + cruiserHits + submarineHits + destroyerHits;

            if (totalHits == totalHitsToSinkAllBoats)
            {
                MessageBox.Show("All boats have been sunk! You win!");
                ResetBoard(); // Reset the board
                NewGame();    // Start a new game
                lblTrnTaken.Text = String.Empty;
            }
        }

        /// <summary>
        /// Hides all boat displays from the board.
        /// Resets button colors to indicate they are hidden.
        /// </summary>
        private void HideAllBoats()
        {
            // Loop through the board and hide all boats
            for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
            {
                for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                {
                    // Find the button based on its name (btnA1, btnB2, etc.)
                    string buttonName = $"btn{(char)(x + 'A' - 1)}{y}";
                    Button gridButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (gridButton != null)
                    {
                        // Reset the button background to default (hide the boat)
                        gridButton.BackColor = SystemColors.Control;
                    }
                }
            }
        }
        #endregion


        #region Game Logic Methods
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
            BS.RandomizeBoats();  // Randomize new boat positions
            ResetBoard();  // Create a method to clear the board and reset the game
            PlaceBoats();
        }
       
        /// <summary>
        /// Displays the full positions of the boats on the board.
        /// Ensures boats are initialized before displaying.
        /// </summary>
        private void btnShowBoard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to see boats?? ", "Show Boats", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ShowFullBoats();
            }
        }

        private int turnCount = 0;

        
       


        
        private void btnGrid_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string name = btn.Name;  // btnA1, btnB2, etc.
            int x = name[3] - 'A' + 1;  // Convert 'A' to 1, 'B' to 2, etc.
            int y = int.Parse(name.Substring(4));  // Extract column number

            // Check if it's a hit or miss
            if (BS.boatPositions[x, y] != BS.Boats.NoBoat)
            {
                if (BS.board[x, y] != BS.BoardStatus.Hit)  // Avoid double-hit counting
                {
                    btn.BackColor = Color.Red;  // Hit
                    BS.board[x, y] = BS.BoardStatus.Hit;
                    UpdateShipProgress(BS.boatPositions[x, y]);  // Update progress bar based on ship
                }
            }
            else
            {
                if (BS.board[x, y] != BS.BoardStatus.Miss)  // Avoid double-miss counting
                {
                    btn.BackColor = Color.Gray;  // Miss
                    BS.board[x, y] = BS.BoardStatus.Miss;
                }
            }
            UpdateTurns();  // Increment turns
        }

        /// <summary>
        /// Updates the progress of a specific ship based on hits received.
        /// Displays messages when a ship is sunk.
        /// </summary>
        /// <param name="shipType">The type of ship that was hit.</param>
        

        /*       private void AssignGridButtonClickEvents()
               {
                   for (int x = 1; x <= BS.MAX_BOARD_SIZE; x++)
                   {
                       for (int y = 1; y <= BS.MAX_BOARD_SIZE; y++)
                       {
                           string buttonName = $"btn{(char)(x + 'A' - 1)}{y}";
                           Button gridButton = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                           if (gridButton != null)
                           {
                               gridButton.Click += new EventHandler(btnGrid_Click);
                           }
                       }
                   }
               }*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                  "Exit Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
           
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = true; // Show the About panel
            btnStart.Visible = false;
            btnAbout.Visible = false;
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            btnStart.Visible = true;
            btnAbout.Visible = true;
        }
        #endregion

    }
}














