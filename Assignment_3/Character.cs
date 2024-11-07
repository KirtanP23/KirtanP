/* *****************************
* Title:   Assignment_3 Character Management 
* Author:  Kirtan Patel
* Date:    November 6, 2024
* Purpose: Manages character attributes, levels, and bonuses for a role-playing game.
* ***************************** */

using Assignment_3;
using System;

public class Character
{
    #region Properties

    /// <summary>Character's name.</summary>
    public string CharacterName { get; set; }

    /// <summary>Character's class (e.g., Warrior, Mage).</summary>
    public string CharacterClass { get; set; }

    /// <summary>Character's race (e.g., Human, Elf).</summary>
    public string CharacterRace { get; set; }

    /// <summary>Character's level, determined by experience points.</summary>
    public int Level { get; set; }

    /// <summary>Character's accumulated experience points.</summary>
    public int ExperiencePoints { get; set; }

    /// <summary>Character's alignment (e.g., Good, Evil).</summary>
    public Constants.Alignment Alignment { get; set; }

    /// <summary>Character's gender.</summary>
    public string Gender { get; set; }

    /// <summary>Strength attribute, default is 8.</summary>
    public int Strength { get; set; } = 8;

    /// <summary>Dexterity attribute, default is 8.</summary>
    public int Dexterity { get; set; } = 8;

    /// <summary>Constitution attribute, default is 8.</summary>
    public int Constitution { get; set; } = 8;

    /// <summary>Intelligence attribute, default is 8.</summary>
    public int Intelligence { get; set; } = 8;

    /// <summary>Wisdom attribute, default is 8.</summary>
    public int Wisdom { get; set; } = 8;

    /// <summary>Charisma attribute, default is 8.</summary>
    public int Charisma { get; set; } = 8;

    /// <summary>Armor class, determines the character's defense.</summary>
    public int ArmourClass { get; set; }

    /// <summary>Initiative score, used to determine turn order.</summary>
    public int Initiative { get; set; }

    /// <summary>Speed attribute, which affects movement.</summary>
    public int Speed { get; set; }

    /// <summary>Hit points, representing health.</summary>
    public int HitPoints { get; set; }

    #endregion

    #region Level Calculation

    /// <summary>
    /// Calculates the character's level based on experience points.
    /// </summary>
    public void CalculateLevel()
    {
        int[] levelXPThresholds = new int[] { 0, 300, 900, 2700, 6500, 14000, 23000, 34000, 48000, 64000, 85000, 100000 };

        for (int i = levelXPThresholds.Length - 1; i >= 0; i--)
        {
            if (ExperiencePoints >= levelXPThresholds[i])
            {
                Level = i + 1;
                break;
            }
        }
    }

    #endregion

    #region Bonuses

    /// <summary>
    /// Applies both race-based and gender-based bonuses to the character's attributes.
    /// </summary>
    public void ApplyBonuses()
    {
        ApplyRaceBonus();
        ApplyGenderBonus();
    }

    /// <summary>
    /// Applies race-based bonuses based on the character's race.
    /// </summary>
    private void ApplyRaceBonus()
    {
        switch (CharacterRace)
        {
            case "Dwarf":
                Strength += 2;
                Constitution += 2;
                break;
            case "Elf (High)":
                Dexterity += 2;
                Intelligence += 1;
                break;
            case "Elf (Wood)":
                Strength += 2;
                Wisdom += 1;
                break;
            case "Halfling":
                Strength += 2;
                Charisma += 1;
                break;
            case "Human":
                Strength += 1;
                Dexterity += 1;
                Constitution += 1;
                Intelligence += 1;
                Wisdom += 1;
                Charisma += 1;
                break;
            case "Dragonborn":
                Strength += 2;
                Charisma += 1;
                break;
            case "Gnome":
                Constitution += 2;
                break;
            case "Half-Elf":
                Strength += 1;
                Dexterity += 1;
                Constitution += 2;
                break;
            case "Half-Orc":
                Strength += 2;
                Dexterity += 1;
                break;
            case "Tiefling":
                Intelligence += 1;
                Charisma += 2;
                break;
            case "Githyanki":
                Dexterity += 2;
                Strength += 1;
                break;
                // Additional races can be added here
        }
    }

    /// <summary>
    /// Applies gender-based bonuses to the character's attributes.
    /// </summary>
    private void ApplyGenderBonus()
    {
        switch (Gender)
        {
            case "Male":
                Strength += 1;
                Wisdom += 1;
                break;
            case "Female":
                Dexterity += 1;
                Intelligence += 1;
                break;
        }
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Overrides the ToString method to display the character's name.
    /// </summary>
    /// <returns>The character's name.</returns>
    public override string ToString()
    {
        return CharacterName;
    }

    #endregion
}
