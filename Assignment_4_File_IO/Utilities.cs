﻿/* Title: Utilities.cs file 
 * Name : Kirtan Patel (100925226)
 * Date: 17 November 2024
 * Purpose: Utilities File for Assignment - 4 
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_4_File_IO
{
    public static class Utilities
    {
        #region Constants

        private const string FilePath = "profiles.txt";

        #endregion

        #region Profile Check

        public static bool ProfileExists(string profileName)
        {
            var profiles = LoadProfiles();
            return profiles.Any(p => p.ProfileName.Equals(profileName, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Save Profile

        public static void SaveProfile(PlayerProfile profile)
        {
            var profiles = LoadProfiles();

            // If the profile is set as default, clear default flag from all other profiles
            if (profile.IsDefault)
            {
                foreach (var p in profiles)
                {
                    p.IsDefault = false;
                }
            }

            if (ProfileExists(profile.ProfileName))
            {
                throw new Exception("A profile with this name already exists. Please choose a different name.");
            }

            profiles.Add(profile);
            SaveAllProfiles(profiles);
        }


        #endregion

        #region Update Profile

        public static void SaveAllProfiles(List<PlayerProfile> profiles)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                foreach (var profile in profiles)
                {
                    writer.WriteLine($"{profile.ProfileName}|{profile.InputDevice}|{profile.AutoJump}|{profile.MouseSensitivity}|{profile.ControllerSensitivity}|" +
                                     $"{profile.InvertYAxis}|{profile.Brightness}|{profile.FancyGraphics}|{profile.VSync}|{profile.Fullscreen}|" +
                                     $"{profile.RenderDistance}|{profile.FieldOfView}|{profile.RayTracing}|{profile.Upscaling}|{profile.MusicVolume}|" +
                                     $"{profile.SoundVolume}|{profile.HUDTransparency}|{profile.ShowCoordinates}|{profile.CameraPerspective}|{profile.IsDefault}");
                }
            }
        }


        #endregion

        #region Load Profiles

        public static List<PlayerProfile> LoadProfiles()
        {
            var profiles = new List<PlayerProfile>();
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var profileData = line.Split('|');
                        if (profileData.Length == 20) // Updated length to include IsDefault
                        {
                            var profile = new PlayerProfile(profileData[0])
                            {
                                InputDevice = (InputDevice)Enum.Parse(typeof(InputDevice), profileData[1]),
                                AutoJump = bool.Parse(profileData[2]),
                                MouseSensitivity = int.Parse(profileData[3]),
                                ControllerSensitivity = int.Parse(profileData[4]),
                                InvertYAxis = bool.Parse(profileData[5]),
                                Brightness = int.Parse(profileData[6]),
                                FancyGraphics = bool.Parse(profileData[7]),
                                VSync = bool.Parse(profileData[8]),
                                Fullscreen = bool.Parse(profileData[9]),
                                RenderDistance = int.Parse(profileData[10]),
                                FieldOfView = int.Parse(profileData[11]),
                                RayTracing = bool.Parse(profileData[12]),
                                Upscaling = bool.Parse(profileData[13]),
                                MusicVolume = int.Parse(profileData[14]),
                                SoundVolume = int.Parse(profileData[15]),
                                HUDTransparency = int.Parse(profileData[16]),
                                ShowCoordinates = bool.Parse(profileData[17]),
                                CameraPerspective = (CameraPerspective)Enum.Parse(typeof(CameraPerspective), profileData[18]),
                                IsDefault = bool.Parse(profileData[19])
                            };
                            profiles.Add(profile);
                        }
                    }
                }
            }
            return profiles;
        }


        #endregion
    }
}
