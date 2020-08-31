/*
 * Author: Joshua Garcia
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T Bone in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// get the price of the T Bone
        /// </summary>
        public double Price { get; }

        /// <summary>
        ///  get the calorie count of the T bone
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// create a list of special instructions for the T Bone
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// constructor that sets the price and calories
        /// </summary>
        public ThugsTBone()
        {
            this.Price = 6.44;
            this.Calories = 982;

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
