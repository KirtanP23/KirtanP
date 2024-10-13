using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class Droid
    {
        #region Class Scope Variables
        public const int MIN_DESIGNATION_LENGTH = 3;
        public const int MAX_DESIGNATION_LENGTH = 8;
        public const int MIN_OWNER_LENGTH = 5;

        public static List<Droid> droids = new List<Droid>();
        #endregion

        #region Properties

        private string _designation;
        /// <summary>
        /// 
        /// </summary>
        public string Designation 
        {        
            get 
            { 
                return _designation; 
            }
            set 
            {
                if (value.Length >= MIN_DESIGNATION_LENGTH && value.Length <= MAX_DESIGNATION_LENGTH)
                {
                    _designation = value;
                }
            }
        }

        public string Owner { get; set; }
        public bool IsInService { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        #endregion

        #region Constructors
        public Droid() 
        { 
        
        }

        public Droid(string designation, string owner, bool isInService, Color primaryColor, Color secondaryColor) 
        { 
            Designation = designation;
            Owner = owner;  
            IsInService = isInService;  
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion

        #region Custom Methods

        public void SellDroid(string owner, bool isInService) 
        { 
            Owner = owner;
            IsInService |= isInService;
        }

        #endregion

        #region Custom Static Methods

        #endregion
    }
}
