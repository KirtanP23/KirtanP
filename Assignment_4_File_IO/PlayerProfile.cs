/* Title: PlayerProfile.cs file 
 * Name : Kirtan Patel (100925226)
 * Date: 17 November 2024
 * Purpose: PlayerProfile File for Assignment - 4 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_File_IO
{
    #region Enums

    public enum InputDevice { Keyboard, Controller, Touch }
    public enum CameraPerspective { FirstPerson, ThirdPersonFront, ThirdPersonBack }

    #endregion

    public class PlayerProfile
    {
        public bool IsDefault { get; set; } = false;
        #region Input Settings

        public InputDevice InputDevice { get; set; } = InputDevice.Keyboard;
        public bool AutoJump { get; set; } = true;
        public int MouseSensitivity { get; set; } = 50;
        public int ControllerSensitivity { get; set; } = 50;
        public bool InvertYAxis { get; set; } = false;

        #endregion

        #region Video Settings

        public int Brightness { get; set; } = 50;
        public bool FancyGraphics { get; set; } = true;
        public bool VSync { get; set; } = true;
        public bool Fullscreen { get; set; } = false;
        public int RenderDistance { get; set; } = 16;
        public int FieldOfView { get; set; } = 64;
        public bool RayTracing { get; set; } = false;
        public bool Upscaling { get; set; } = false;

        #endregion

        #region Audio Settings

        public int MusicVolume { get; set; } = 100;
        public int SoundVolume { get; set; } = 100;

        #endregion

        #region Interface Settings

        public int HUDTransparency { get; set; } = 100;
        public bool ShowCoordinates { get; set; } = false;
        public CameraPerspective CameraPerspective { get; set; } = CameraPerspective.FirstPerson;

        #endregion

        #region Profile Information

        public string ProfileName { get; set; }

        #endregion

        #region Constructors

        public PlayerProfile(string profileName)
        {
            ProfileName = profileName;
        }

        #endregion

        #region Methods

        // Method to Generate String Representation (for saving to file)
        public override string ToString()
        {
            return $"Profile: {ProfileName}\nInput Device: {InputDevice}\nAuto-Jump: {AutoJump}\n...";
        }

        #endregion
    }
}
