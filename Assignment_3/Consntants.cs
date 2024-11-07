/* *****************************
* Title:   Assignment_3 Alignment Management 
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: Manages alignment 
* ***************************** */

namespace Assignment_3
{
    /// <summary>
    /// A static class to hold constants for the game, including alignment and attribute names.
    /// </summary>
    public static class Constants
    {
        #region Enums

        /// <summary>
        /// Represents the alignment of a character, affecting their behavior and morality.
        /// </summary>
        public enum Alignment
        {
            /// <summary>Represents a lawful good alignment.</summary>
            LawfulGood,

            /// <summary>Represents a neutral good alignment.</summary>
            NeutralGood,

            /// <summary>Represents a chaotic good alignment.</summary>
            ChaoticGood,

            /// <summary>Represents a lawful neutral alignment.</summary>
            LawfulNeutral,

            /// <summary>Represents a neutral alignment.</summary>
            Neutral,

            /// <summary>Represents a chaotic neutral alignment.</summary>
            ChaoticNeutral,

            /// <summary>Represents a lawful evil alignment.</summary>
            LawfulEvil,

            /// <summary>Represents a neutral evil alignment.</summary>
            NeutralEvil,

            /// <summary>Represents a chaotic evil alignment.</summary>
            ChaoticEvil
        }
        #endregion
    }
}
