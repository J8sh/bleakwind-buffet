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
    public class VokunSalad
    {
        private Size size = Size.Small;

        public Size Size { get; set; }

        /// <summary>
        /// get Price of Smoke house Skeleton
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// get Calories for the Smoke house Skeleton
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "{Size} Vokun Salad";
        }

    }
}
