/*
 * Author: Joshua Garcia
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger in the Entrees namespace
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    public class BriarheartBurger
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
        /// special instructions for the burger
        /// </summary>
        String[] Instructions = { "Hold bun", "Hold ketchup", "Hold mustard", "Hold pickle", "Hold cheese" };

        /// <summary>
        /// constructor with the set price and calories
        /// </summary>
        public BriarheartBurger()
        {
            this.Price = 6.32;
            this.Calories = 743;
            
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }




    }
}
