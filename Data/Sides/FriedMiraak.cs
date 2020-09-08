/*
 * Author: Joshua Garcia
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak in the Sides namespace
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side
    {
        /// <summary>
        /// get the size of the meal
        /// </summary>
        //private Size size = Size.Small;

        /// <summary>
        /// get Price of Fried Miraak different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get Calories for the Fried Miraak different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get special instructions
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
            return Size.ToString() + " Fried Miraak";
        }

    }
}

