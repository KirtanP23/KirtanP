/* *****************************
* Title:   Assignment_3 Race Management 
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: Manages races and bonuses based on races
* ***************************** */

using System.Collections.Generic;

namespace Assignment_3
{
    /// <summary>
    /// Represents a race in the game, with associated bonuses to character attributes.
    /// </summary>
    public class Race
    {
        #region Properties

        /// <summary>Name of the race.</summary>
        public string Name { get; set; }

        /// <summary>Description of the race.</summary>
        public string Description { get; set; }

        /// <summary>Strength bonus for the race.</summary>
        public int StrengthBonus { get; set; }

        /// <summary>Dexterity bonus for the race.</summary>
        public int DexterityBonus { get; set; }

        /// <summary>Constitution bonus for the race.</summary>
        public int ConstitutionBonus { get; set; }

        /// <summary>Intelligence bonus for the race.</summary>
        public int IntelligenceBonus { get; set; }

        /// <summary>Wisdom bonus for the race.</summary>
        public int WisdomBonus { get; set; }

        /// <summary>Charisma bonus for the race.</summary>
        public int CharismaBonus { get; set; }

        #endregion

        #region Static List of Available Races

        /// <summary>
        /// A static list containing all available races in the game.
        /// </summary>
        public static List<Race> AvailableRaces { get; } = new List<Race>
        {
            new Race
            {
                Name = "Human",
                Description = "Versatile and resilient.",
                StrengthBonus = 1,
                DexterityBonus = 1,
                ConstitutionBonus = 1,
                IntelligenceBonus = 1,
                WisdomBonus = 1,
                CharismaBonus = 1
            },
            new Race
            {
                Name = "Elf",
                Description = "Graceful and magical.",
                DexterityBonus = 2
            },
            new Race
            {
                Name = "Dwarf",
                Description = "Stout and hardy.",
                ConstitutionBonus = 2,
                StrengthBonus = 2
            },
            new Race
            {
                Name = "Halfling",
                Description = "Small and nimble.",
                DexterityBonus = 2,
                CharismaBonus = 1
            },
            new Race
            {
                Name = "Dragonborn",
                Description = "Descendant of dragons.",
                StrengthBonus = 2,
                CharismaBonus = 1
            },
            new Race
            {
                Name = "Gnome",
                Description = "Inventive and curious.",
                IntelligenceBonus = 2,
                DexterityBonus = 1
            },
            new Race
            {
                Name = "Half-Elf",
                Description = "A mix of human and elf heritage.",
                CharismaBonus = 2,
                DexterityBonus = 1,
                IntelligenceBonus = 1
            },
            new Race
            {
                Name = "Half-Orc",
                Description = "Strong and intimidating.",
                StrengthBonus = 2,
                DexterityBonus = 1
            },
            new Race
            {
                Name = "Tiefling",
                Description = "A being of infernal heritage.",
                IntelligenceBonus = 1,
                CharismaBonus = 2
            },
            new Race
            {
                Name = "Githyanki",
                Description = "Psionic and disciplined.",
                StrengthBonus = 1,
                DexterityBonus = 2
            }
        };
        #endregion
    }
}
