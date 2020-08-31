/*
* Author: Joshua Garcia
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent the Candlehearth Coffee in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {

        /// <summary>
        /// use ice 
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// coffee is not decaf by default
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// no room for cream by default
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// determines what size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// getter/setter for ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// getter/setter for decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// getter/setter for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// getter/setter for drink size
        /// </summary>
        public Size Size { get; set; }

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
        String[] Instructions = { "Add ice", "Add cream" };

        public CandlehearthCoffee()
        {

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            
            if(Decaf == true)
            {
                return "{Size} Decaf Candlehearth Coffee";
            }

            return "{Size} Candlehearth Coffee";
        }



    }
}
