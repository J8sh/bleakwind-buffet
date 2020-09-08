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
    public class ThalmorTriple : Entree
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
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// getter/setter for the ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// getter/setter for the mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// getter/setter for the pickles
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// getter/setter for the cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// getter/setter for the tomatoes
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
        /// getter/setter for the lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// getter/setter for the mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
            }
        }

        /// <summary>
        /// getter/setter for the bacon
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
            }
        }

        /// <summary>
        /// getter/settter for the eggs
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// get the price for the Thalmor Triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// get the calorie count for the Thalmor Triple
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
            }
        }

        /// <summary>
        /// get any special instructions for the Thalmor Triple
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
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
