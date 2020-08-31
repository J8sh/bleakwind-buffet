/*
* Author: Joshua Garcia
* Class name: WarriorWater.cs
* Purpose: Class used to represent the Warrior Water in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// use ice 
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// add lemon, no by default
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// determines what size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// getter/setter for ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// getter/setter for drink size
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// getter/setter for lemon value
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// get the price value
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// get the calorie amount
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// holds the special instructions
        /// </summary>
        String[] Instructions = { "Hold ice", "Add lemon" };

        public WarriorWater()
        {
            this.Price = 0.00;
            this.Calories = 0;

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            return "{Size} Warrior Water";
        }




    }

}
