/* *****************************
* Title:   Assignment_3 Class Management 
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: Manages classes 
* ***************************** */

using System.Collections.Generic;

namespace Assignment_3
{
    /// <summary>
    /// Represents a character's class, defining their abilities and role.
    /// </summary>
    public class Class
    {
        #region Properties

        /// <summary>
        /// The name of the character class (e.g., Fighter, Wizard).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the character class, outlining its abilities and role.
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region Static Fields

        /// <summary>
        /// A list of all available character classes.
        /// </summary>
        public static List<Class> AvailableClasses { get; } = new List<Class>
        {
            new Class { Name = "Fighter", Description = "A warrior trained for physical combat." },
            new Class { Name = "Wizard", Description = "A spellcaster who uses magic and spells." },
            new Class { Name = "Cleric", Description = "A priestly champion who wields divine magic." },
            new Class { Name = "Druid", Description = "A priest of the Old Faith, wielding the powers of nature." },
            new Class { Name = "Monk", Description = "A master of martial arts, harnessing the power of the body." },
            new Class { Name = "Paladin", Description = "A holy warrior bound to a sacred oath." },
            new Class { Name = "Ranger", Description = "A warrior who uses martial prowess and nature magic." },
            new Class { Name = "Rogue", Description = "A scoundrel who uses stealth and trickery." },
            new Class { Name = "Sorcerer", Description = "A spellcaster who draws on inherent magic." },
            new Class { Name = "Warlock", Description = "A wielder of magic derived from a bargain." },
            new Class { Name = "Wizard", Description = "A scholarly magic-user capable of powerful spells." }
        };
        #endregion
    }
}
