/*
 * Author: Joshua Garcia
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {

        /// <summary>
        /// sirloin is true by default
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// onion is true by default
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// roll is true by default
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// get the bool for the Sirloin
        /// </summary>
        public bool Sirloin { get; set; }

        /// <summary>
        /// get the bool for the Onion
        /// </summary>
        public bool Onion { get; set; }

        /// <summary>
        /// get the bool for the Roll
        /// </summary>
        public bool Roll { get; set; }

        /// <summary>
        /// price for the Philly Poacher
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// get the calories for the philly poacher
        /// </summary>
        public uint Calories { get; }
        
        /// <summary>
        /// get the special instructions for the Philly Poacher
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// different instruction options
        /// </summary>
        String[] Instructions = { "Hold sirloin", "Hold onions", "Hold roll" };

        /// <summary>
        /// Constructor with the price and calories set
        /// </summary>
        public PhillyPoacher()
        {
            this.Price = 7.23;
            this.Calories = 784;
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }





    }
}
