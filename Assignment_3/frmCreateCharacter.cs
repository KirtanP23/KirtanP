/* *****************************
* Title:   Assinment_3 Create & Edit Character File
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: To create a new character and/or edit an existing character created by user
* ***************************** */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class frmCreateCharacter : Form
    {
        #region Fields and Properties

        /// <summary>
        /// List to store characters.
        /// </summary>
        public List<Character> CharacterList = new List<Character>();

        /// <summary>
        /// Character to edit.
        /// </summary>
        private Character characterToEdit; //referenced from ChatGpt

        /// <summary>
        /// Flag to check if the form is in edit mode.
        /// </summary>
        private bool isEditing; //referenced from ChatGpt

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor for creating a new character.
        /// </summary>
        public frmCreateCharacter()
        {
            InitializeComponent();
            isEditing = false;
        }

        /// <summary>
        /// Constructor for editing an existing character.
        /// </summary>
        /// <param name="character">Character to edit.</param>
        public frmCreateCharacter(Character character) : this() // reference from CHatGpt
        {
            characterToEdit = character;
            isEditing = true;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Loads the form and initializes controls.
        /// </summary>
        private void frmCreateCharacter_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
            if (isEditing)
            {
                LoadCharacterData();
            }
        }

        /// <summary>
        /// Handles the Save button click event.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                UpdateCharacter();
            }
            else
            {
                CreateNewCharacter();
            }
            this.Close();
        }

        /// <summary>
        /// Handles the Exit button click event.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Populates combo boxes for character properties.
        /// </summary>
        private void PopulateComboBoxes()
        {
            // Populate Class ComboBox
            cmbClass.DataSource = Class.AvailableClasses;
            cmbClass.DisplayMember = "Name";
            cmbClass.ValueMember = "Name";

            // Populate Race ComboBox
            cmbRace.DataSource = Race.AvailableRaces;
            cmbRace.DisplayMember = "Name";
            cmbRace.ValueMember = "Name";

            // Populate Alignment ComboBox
            cmbAlignment.DataSource = Enum.GetValues(typeof(Constants.Alignment));
        }

        /// <summary>
        /// Loads character data into the form for editing.
        /// </summary>
        private void LoadCharacterData()
        {
            txtCharName.Text = characterToEdit.CharacterName;
            cmbClass.SelectedItem = characterToEdit.CharacterClass;
            cmbRace.SelectedItem = characterToEdit.CharacterRace;
            cmbAlignment.SelectedItem = characterToEdit.Alignment;
            rdbMale.Checked = characterToEdit.Gender == "Male";
            rdbFemale.Checked = characterToEdit.Gender == "Female";

            nudLevel.Value = characterToEdit.Level;
            nudExpPoints.Value = characterToEdit.ExperiencePoints;
            nudStrength.Value = characterToEdit.Strength;
            nudDexiterity.Value = characterToEdit.Dexterity;
            nudConstitution.Value = characterToEdit.Constitution;
            nudIntelligence.Value = characterToEdit.Intelligence;
            nudWisdom.Value = characterToEdit.Wisdom;
            nudCharisma.Value = characterToEdit.Charisma;
            nudArmour.Value = characterToEdit.ArmourClass;
            nudInitiative.Value = characterToEdit.Initiative;
            nudSpeed.Value = characterToEdit.Speed;
            nudHitPoints.Value = characterToEdit.HitPoints;
        }

        /// <summary>
        /// Updates the character being edited with new values.
        /// </summary>
        private void UpdateCharacter()
        {
            characterToEdit.CharacterName = txtCharName.Text;
            characterToEdit.CharacterClass = cmbClass.SelectedValue.ToString();
            characterToEdit.CharacterRace = cmbRace.SelectedValue.ToString();
            characterToEdit.Level = (int)nudLevel.Value;
            characterToEdit.ExperiencePoints = (int)nudExpPoints.Value;
            characterToEdit.Alignment = (Constants.Alignment)cmbAlignment.SelectedItem;
            characterToEdit.Gender = rdbMale.Checked ? "Male" : "Female";

            characterToEdit.Strength = (int)nudStrength.Value;
            characterToEdit.Dexterity = (int)nudDexiterity.Value;
            characterToEdit.Constitution = (int)nudConstitution.Value;
            characterToEdit.Intelligence = (int)nudIntelligence.Value;
            characterToEdit.Wisdom = (int)nudWisdom.Value;
            characterToEdit.Charisma = (int)nudCharisma.Value;
            characterToEdit.ArmourClass = (int)nudArmour.Value;
            characterToEdit.Initiative = (int)nudInitiative.Value;
            characterToEdit.Speed = (int)nudSpeed.Value;
            characterToEdit.HitPoints = (int)nudHitPoints.Value;

            characterToEdit.ApplyBonuses();
            characterToEdit.CalculateLevel();
        }

        /// <summary>
        /// Creates a new character and adds it to the main form.
        /// </summary>
        private void CreateNewCharacter()
        {
            Character newCharacter = new Character
            {
                CharacterName = txtCharName.Text,
                CharacterClass = cmbClass.SelectedValue.ToString(),
                CharacterRace = cmbRace.SelectedValue.ToString(),
                Level = (int)nudLevel.Value,
                ExperiencePoints = (int)nudExpPoints.Value,
                Alignment = (Constants.Alignment)cmbAlignment.SelectedItem,
                Gender = rdbMale.Checked ? "Male" : "Female",

                Strength = (int)nudStrength.Value,
                Dexterity = (int)nudDexiterity.Value,
                Constitution = (int)nudConstitution.Value,
                Intelligence = (int)nudIntelligence.Value,
                Wisdom = (int)nudWisdom.Value,
                Charisma = (int)nudCharisma.Value,
                ArmourClass = (int)nudArmour.Value,
                Initiative = (int)nudInitiative.Value,
                Speed = (int)nudSpeed.Value,
                HitPoints = (int)nudHitPoints.Value
            };

            newCharacter.ApplyBonuses();
            newCharacter.CalculateLevel();

            //referenced from ChatGpt
            frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.CharacterList.Add(newCharacter);
                mainForm.UpdateCharacterList();
            }
        }
        #endregion
    }
}
