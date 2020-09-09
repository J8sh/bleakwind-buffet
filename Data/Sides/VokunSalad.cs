/*
 * Author: Joshua Garcia
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad in the Sides namespace
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A Class for Vokun Salad item
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// setting size for the meal
        /// </summary>
        //private Size size = Size.Small;

        /// <summary>
        /// get Price of VokunSalad different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get Calories for the VokunSalad different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// create special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }

    }
}
