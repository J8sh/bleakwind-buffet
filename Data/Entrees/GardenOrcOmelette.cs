/*
 * Author: Joshua Garcia
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// broccoli are included by default
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// mushrooms are included by default
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// tomato are included by default
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// cheddar are included by default
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// get/set for Broccoli
        /// </summary>
        public bool Broccoli { get; set; }

        /// <summary>
        /// get/set for Mushrooms
        /// </summary>
        public bool Mushrooms { get; set; }

        /// <summary>
        /// getter/setter for Tomatos
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// getter/setter for Cheddar
        /// </summary>
        public bool Cheddar { get; set; }

        /// <summary>
        /// get price of Omelette
        /// </summary>
        public double Price { get; }
        
        /// <summary>
        /// get calories of Omelette
        /// </summary>
        public uint Calories { get; }
        
        /// <summary>
        /// get instructions for the Omelette
        /// </summary>
        public List<String> SpecialInstructions { get; }

        String[] Instructions = { "Hold broccoli", "Hold mushrooms", "Hold tomato", "Hold cheddar" };

        /// <summary>
        /// constructor with set Price and calories
        /// </summary>
        public GardenOrcOmelette()
        {
            this.Price = 4.57;
            this.Calories = 404;

        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }





    }
}
