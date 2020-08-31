/*
 * Author: Joshua Garcia
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple in the Entrees namespace
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple 
    {
        /// <summary>
        /// bun are included by defualt 
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// ketchup is included by default
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// mustard is included by default
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// pickles are included by default
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// cheese is included by  default
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// tomatoes are included by default
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// lettuce is included by default
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        ///  mayo is included by default
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// bacon is included by default
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// egg is included by default
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// getter/setter for the bun
        /// </summary>
        public bool Bun { get; set; }

        /// <summary>
        /// getter/setter for the ketchup
        /// </summary>
        public bool Ketchup { get; set; }

        /// <summary>
        /// getter/setter for the mustard
        /// </summary>
        public bool Mustard { get; set; }

        /// <summary>
        /// getter/setter for the pickles
        /// </summary>
        public bool Pickle { get; set; }

        /// <summary>
        /// getter/setter for the cheese
        /// </summary>
        public bool Cheese { get; set; }

        /// <summary>
        /// getter/setter for the tomatoes
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// getter/setter for the lettuce
        /// </summary>
        public bool Lettuce { get; set; }

        /// <summary>
        /// getter/setter for the mayo
        /// </summary>
        public bool Mayo { get; set; }

        /// <summary>
        /// getter/setter for the bacon
        /// </summary>
        public bool Bacon { get; set; } 

        /// <summary>
        /// getter/settter for the eggs
        /// </summary>
        public bool Egg { get; set; }

        /// <summary>
        /// get the price for the Thalmor Triple
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// get the calorie count for the Thalmor Triple
        /// </summary>
        public uint Calories { get; }
        
        /// <summary>
        /// get any special instructions for the Thalmor Triple
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// list of special instructions
        /// </summary>
        String[] Instructions = { "Hold bacon", "Hold egg" };

        /// <summary>
        /// constructor that sets the price and calories 
        /// </summary>
        public ThalmorTriple()
        {
            this.Price = 8.32;
            this.Calories = 943;

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }


    }
}
