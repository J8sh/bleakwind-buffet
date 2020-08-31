/*
* Author: Joshua Garcia
* Class name: SailorSoda.cs
* Purpose: Class used to represent the Sailor's Soda in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public partial class SailorSoda
    {
        /// <summary>
        /// use ice 
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// determines what size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// detemines what soda flavor
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// getter/setter for ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// getter/setter for drink size
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// getter/setter for soda flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; }

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
        String[] Instructions = { "Hold ice" };

        public SailorSoda()
        {
            
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            return "{Size} {Flavor} Sailor Soda";
        }

    }
}
