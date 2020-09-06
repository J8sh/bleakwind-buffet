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
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// default size of meal
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// getter/setter for the size of meal
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
        /// get Price of Dragonborn Waffle Fries size
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get Calories for the size of meal 
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
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
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffles Fries";
        }

    }
}
