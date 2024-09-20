/* ***********************************
Name: Kirtan Patel Student Id: 100925226
 IN_CLASS EXERCISE_1
Date: 20 Sept 2024
 This program creates runs two games simultaneously :
1. Guess The Number Game where user guesses a random number according to difficulty level
2. An Ice Cream Shop system where user can buy any ice cream of their choice
 */



using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InClass1
{
    public partial class frmMain : Form
    {
        // Global variables for Ice Cream Shop
        double cashBoxBalance = 100.0; // Initial cash balance
        double orderTotal = 0.0; // Keeps track of the current order total
        double customerPayment = 0.0;// Stores the total payment amount
        double paymentAmount = 0.0;

        #region Constructor

        /// <summary>
        /// Initializes the form components and sets the initial states of panels.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            // Set up initial states
            panIceCream.Visible = false;
            panGuessTheNumber.Visible = false;
        }
        #endregion

        #region Form Load Event

        /// <summary>
        /// Event handler for form load. Sets default values when the form is first loaded.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
            /*UpdateCashBoxDisplay();*/ // Show initial cash box balance
        }
        #endregion

        #region Default Settings

        /// <summary>
        /// Sets the default settings for both Guess The Number and Ice Cream Shop.
        /// </summary>
        private void SetDefaults()
        {
            SetGTN_Defaults();
        }

        /// <summary>
        /// Sets default values for the Guess The Number game.
        /// </summary>
        private void SetGTN_Defaults()
        {
            cbo_GTN_Difficulty.SelectedIndex = 0;
            nudGuessedNumber.Minimum = Settings.GTN_Minimum;
            SetGTNMaximum();
        }

        /// <summary>
        /// Adjusts the maximum number based on the selected difficulty level.
        /// </summary>
        private void SetGTNMaximum()
        {
            switch (cbo_GTN_Difficulty.SelectedIndex)
            {
                case 1:
                    nudGuessedNumber.Maximum = Settings.GTN_MaxMedium;
                    lblGTNMaximum.Text = Settings.GTN_MaxMedium.ToString();
                    break;
                case 2:
                    nudGuessedNumber.Maximum = Settings.GTN_MaxHard;
                    lblGTNMaximum.Text = Settings.GTN_MaxHard.ToString();
                    break;
                default:
                    nudGuessedNumber.Maximum = Settings.GTN_MaxEasy;
                    lblGTNMaximum.Text = Settings.GTN_MaxEasy.ToString();
                    break;
            }

            nudGTNRandomNumber.Value = Tools.RandomInt(Settings.GTN_Minimum, (int)nudGuessedNumber.Maximum);
            nudGTNNumGuesses.Value = 0;
        }
        #endregion

        #region Event Handlers - Guess the Number Game

        /// <summary>
        /// Handles the event when difficulty level is changed.
        /// Adjusts the maximum guessable number accordingly.
        /// </summary>
        private void cbo_GTN_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNMaximum();
        }

        /// <summary>
        /// Opens the Guess The Number game panel.
        /// </summary>
        private void btnGuessTheNumber_Click(object sender, EventArgs e)
        {
            panGuessTheNumber.Visible = true;
            panIceCream.Visible = false;

            SetGTN_Defaults();
        }

        /// <summary>
        /// Handles the Guess button click event.
        /// Compares the guessed number with the random number and provides feedback.
        /// </summary>
        private void btn_GTN_Guess_Click(object sender, EventArgs e)
        {
            nudGTNNumGuesses.Value += 1;

            // compare guess to value
            if (nudGuessedNumber.Value > nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO HIGH!\n";
            }
            else if (nudGuessedNumber.Value < nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO LOW!\n";
            }
            else
            {
                lbl_GTN_Output.Text += "YEAH! You got it! It took you " + nudGTNNumGuesses.Value + " guesses\n";
            }
        }
        #endregion

        #region Ice Cream Application Code


        /// <summary>
        /// Opens the Ice Cream Shop panel.
        /// </summary>
        private void btnIceCream_Click(object sender, EventArgs e)
        {
            panGuessTheNumber.Visible = false;
            panIceCream.Visible = true;
            txtCashBalance_TextChanged(sender, e);
        }

        /// <summary>
        /// Adds the selected ice cream item to the current order.
        /// </summary>
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (lstIceCreamItems.SelectedItems != null)
            {
                string product = lstIceCreamItems.SelectedItem.ToString();
                int quantity = (int)nudQuantity.Value;
                double price = 0;

                switch (product)
                {
                    case "Chocolate - $2.00":
                        price = 2.00;
                        break;
                    case "Mint Chocolate - $3.00":
                        price = 3.00;
                        break;
                    case "Vanila - $2.50":
                        price = 2.50;
                        break;
                    case "Cookie Cream - $3.50":
                        price = 3.50;
                        break;
                    case "Strawberry - $2.00":
                        price = 2.00;
                        break;
                }

                double totalPrice = quantity * price;
                string itemText = $"{product} x {quantity} = ${totalPrice:F2}"; // Update item text with correct total price
                lstCurrentOrder.Items.Add(itemText);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        /// <summary>
        /// Removes the selected item from the current order.
        /// </summary>
        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (lstCurrentOrder.SelectedIndex != -1)
            {
                lstCurrentOrder.Items.RemoveAt(lstCurrentOrder.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
        /// <summary>
        /// Calculates the total order price and updates the payment textbox.
        /// </summary>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            orderTotal = CalculateOrderTotal();
            txtPayment.Text = $"${orderTotal:F2}"; // Update txtPayment with correct total price
        }

        // New: Calculate Change Due
        /// <summary>
        /// Calculates the change due based on customer payment and order total.
        /// </summary>
        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            double customerPayment = double.Parse(txtPayment.Text); // Amount entered by the customer
            double changeDue = customerPayment - orderTotal;

            if (changeDue >= 0)
            {
                txtChangeDue.Text = $"${changeDue:F2}";
                cashBoxBalance += orderTotal; // Update cash box balance after successful payment
            }
            else
            {
                MessageBox.Show("Insufficient payment. Please enter a valid amount.");
            }
        }


        /// <summary>
        /// Adds a specific amount to the payment via quick payment buttons.
        /// </summary>
        // New: Payment Buttons for Quick Selection
        
        private void RecieveAmount(double customerPayment)
        {
            customerPayment = customerPayment - orderTotal;
            txtChangeDue.Text = $"${customerPayment:F2}";
        }

        private void AddPaymentAmount(double amount)
        {
            paymentAmount += amount;
            txtPayment.Text = $"${paymentAmount:F2}";
        }
        /// <summary>
        /// Calculates the total price of the current order.
        /// </summary>
        /// <returns>Total order price.</returns>
        private double CalculateOrderTotal()
        {
            double totalPrice = 0;
            foreach (string item in lstCurrentOrder.Items)
            {
                string[] parts = item.Split('=');
                if (parts.Length == 2)
                {
                    double itemTotal = double.Parse(parts[1].Replace("$", "").Trim());
                    totalPrice += itemTotal;
                }
            }
            return totalPrice;
        }
        #endregion


        #region Payment Buttons
        private void btnDollarFiveClick_Click(object sender, EventArgs e)
        {
            RecieveAmount(5);
        }

        private void btnOneDollarClick_Click(object sender, EventArgs e)
        {
            RecieveAmount(1);
        }

        private void btnTenDollarClick_Click(object sender, EventArgs e)
        {
            RecieveAmount(10);
        }
        private void btnTwentyDollarClick_Click(object sender, EventArgs e)
        {
            RecieveAmount(20);
        }
        private void btnFiftyDollarClick_Click(object sender, EventArgs e)
        {
            RecieveAmount(50);
        }


        #endregion

        #region Miscellanous Events
        /// <summary>
        /// Updates the cash balance display.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            orderTotal = 0;
            RecieveAmount(0);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            txtPayment.Clear();
            txtChangeDue.Clear();
        }

        private void txtCashBalance_TextChanged(object sender, EventArgs e)
        {
            txtCashBalance.Text = $" $ {cashBoxBalance} ";
        }


        /// <summary>
        /// Closes the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (customerPayment - orderTotal < 0)
            {
                MessageBox.Show("Total Payment is Wrong");
            }
            else
            {
                cashBoxBalance += orderTotal;
                this.resetpanIceCream(sender, e);
            }
        }
        #endregion

        private void resetpanIceCream(object sender, EventArgs e)
        {
            orderTotal = 0;
            RecieveAmount(0);
            lstCurrentOrder.Items.Clear();
            this.txtCashBalance_TextChanged(sender, e);
            txtPayment.Clear();
            txtChangeDue.Clear();
        }

    }
}
