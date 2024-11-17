/* *****************************
* Title:   Assignment_3 Character Management 
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: display created characters and provide options to add a new character or edit an existing one
* ***************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class frmMain : Form
    {
        #region Fields and Properties

        /// <summary>
        /// List to store all created characters.
        /// </summary>
        public List<Character> CharacterList = new List<Character>();

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            UpdateCharacterList();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateCharacterList();
        }

        /// <summary>
        /// Handles the Create Character button click event.
        /// Opens a new character creation form.
        /// </summary>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            frmCreateCharacter createForm = new frmCreateCharacter();
            createForm.ShowDialog();
            UpdateCharacterList();
        }

        /// <summary>
        /// Handles the Edit Character button click event.
        /// Opens the character creation form in edit mode for the selected character.
        /// </summary>
        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            if (lbxCharList.SelectedItem != null)
            {
                Character selectedCharacter = (Character)lbxCharList.SelectedItem;
                frmCreateCharacter editForm = new frmCreateCharacter(selectedCharacter);
                editForm.ShowDialog();
                UpdateCharacterList();
            }
            else
            {
                MessageBox.Show("Please select a character to edit.", "Edit Character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the ListBox selection change event.
        /// Displays details of the selected character.
        /// </summary>
        private void lbxCharList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCharList.SelectedIndex > -1)
            {
                Character selectedCharacter = (Character)lbxCharList.SelectedItem;
                DisplayCharacterDetails(selectedCharacter);
            }
        }

        /// <summary>
        /// Handles the Exit button click event.
        /// Exits the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Updates the character list in the ListBox.
        /// </summary>
        public void UpdateCharacterList()
        {
            lbxCharList.Items.Clear();
            foreach (var character in CharacterList)
            {
                lbxCharList.Items.Add(character);
            }
        }

        /// <summary>
        /// Displays the details of a character in the RichTextBox.
        /// </summary>
        /// <param name="character">Character whose details are to be displayed.</param>
        private void DisplayCharacterDetails(Character character)
        {
            rtbCharacterDetails.Text = $"Name: {character.CharacterName}\n" +
                                       $"Class: {character.CharacterClass}\n" +
                                       $"Race: {character.CharacterRace}\n" +
                                       $"Level: {character.Level}\n" +
                                       $"Alignment: {character.Alignment}\n" +
                                       $"Strength: {character.Strength}\n" +
                                       $"Dexterity: {character.Dexterity}\n" +
                                       $"Constitution: {character.Constitution}\n" +
                                       $"Intelligence: {character.Intelligence}\n" +
                                       $"Wisdom: {character.Wisdom}\n" +
                                       $"Charisma: {character.Charisma}\n" +
                                       $"Armor Class: {character.ArmourClass}\n" +
                                       $"Initiative: {character.Initiative}\n" +
                                       $"Speed: {character.Speed}\n" +
                                       $"Hit Points: {character.HitPoints}";
        }

        #endregion
    }
}