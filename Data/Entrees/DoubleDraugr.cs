/*
 * Author: Joshua Garcia
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// property for the burger price
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// property for the Calorie total
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// list property for any special instruction on the burger
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// bool to include bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// bool to include ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// bool to include mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// bool to include pickles
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// bool to include cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// bool to include tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// bool to include lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// bool to include mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// getter setter for Bun
        /// </summary>
        public bool Bun { get; set; }

        /// <summary>
        /// getter / setter for the ketchup
        /// </summary>
        public bool Ketchup { get; set; }

        /// <summary>
        /// getter / setter for the Mustard
        /// </summary>
        public bool Mustard { get; set; }

        /// <summary>
        /// getter / setter for the Pickles
        /// </summary>
        public bool Pickle { get; set; }

        /// <summary>
        /// getter / setter for the Cheese
        /// </summary>
        public bool Cheese { get; set; }

        /// <summary>
        /// getter and setter for the Tomato
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// getter and setter for the Lettuce
        /// </summary>
        public bool Lettuce { get; set; }

        /// <summary>
        /// getter and setter for the Mayo
        /// </summary>
        public bool Mayo { get; set; }

        /// <summary>
        /// special instructions for the doubleDraugr
        /// </summary>
        String[] Instructions = { "Hold tomato", "Hold lettuce", "Hold mayo" };

        /// <summary>
        /// Constructor to set price and calories
        /// </summary>
        public DoubleDraugr()
        {
            this.Price = 7.32;
            this.Calories = 843;

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

    }
}
