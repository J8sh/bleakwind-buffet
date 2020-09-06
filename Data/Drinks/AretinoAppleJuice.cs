/*
* Author: Joshua Garcia
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent the Aretino Apple Juice in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// use ice 
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// determines what size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// getter/setter for ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// getter/setter for drink size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// get the price value
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get the calorie amount
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            return Size.ToString() + " Aretino Apple Juice";
        }



    }
}
