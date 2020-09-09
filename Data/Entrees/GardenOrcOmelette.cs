/*
 * Author: Joshua Garcia
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A Class for Garden Orc Omelette item
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
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
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
            }
        }

        /// <summary>
        /// get/set for Mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
            }
        }

        /// <summary>
        /// getter/setter for Tomatos
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// getter/setter for Cheddar
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
            }
        }

        /// <summary>
        /// get price of Omelette
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// get calories of Omelette
        /// </summary>
        public override uint Calories
        {
            get { return 404; }
        }

        /// <summary>
        /// get instructions for the Omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
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
