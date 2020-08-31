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
    public class MarkarthMilk
    {
        /// <summary>
        /// no ice is added by default
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// default size of small
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// get value of ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// get size of cup
        /// </summary>
        public Size Size { get; set; }
            
        /// <summary>
        /// get price of drink
        /// </summary>
        public double Price { get; }
            
        /// <summary>
        /// get calorie amount of drink
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public List<String> SpecialInstructions { get; }

        // <summary>
        /// holds the special instructions
        /// </summary>
        String[] Instructions = { "Add ice" };

        public MarkarthMilk()
        {

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            return "{Size} Markarth Milk";
        }

    }
}
