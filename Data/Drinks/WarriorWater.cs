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
        /// getter/setter for lemon value
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// get the price value
        /// </summary>
        public double Price
        {
            get
            {
                return 0.00;
            }
        }

        /// <summary>
        /// get the calorie amount
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            return Size.ToString() + " Warrior Water";
        }




    }

}
