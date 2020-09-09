/*
* Author: Joshua Garcia
* Class name: MarkarthMilk.cs
* Purpose: Class used to represent the Markath Milk in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A Class for Markarth Milk item
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// no ice is added by default
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// default size of small
        /// </summary>
        //private Size size = Size.Small;

        /// <summary>
        /// get value of ice
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
        /// get price of drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException();
                }
            }
        }
            
        /// <summary>
        /// get calorie amount of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " Markarth Milk";
        }

    }
}
