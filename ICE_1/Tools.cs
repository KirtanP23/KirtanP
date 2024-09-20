/*
 * COSC2100 Section 4 F2024
 * Written by Clint McDonald 
 * Modified by Kirtan Patel ( 100925226 )
 * Sept 19, 2024
 * General Tools
 * */

using System;
using System.Drawing;

namespace InClass1
{
    public static class Tools
    {
        #region Fields
        static Random random = new Random();
        #endregion

        #region Methods
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static Color RandomColor()
        {
            return Color.FromArgb(255, RandomInt(0, 255), RandomInt(0, 255), RandomInt(0, 255));
        }
        #endregion

    }
}
