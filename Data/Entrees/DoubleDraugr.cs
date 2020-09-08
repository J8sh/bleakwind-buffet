/*
 * Author: Joshua Garcia
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree
    {
        /// <summary>
        /// property for the burger price
        /// </summary>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// property for the Calorie total
        /// </summary>
        public override uint Calories
        {
            get { return 843; }
        }


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
        /// getter / setter for the ketchup
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
        /// getter / setter for the Mustard
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
        /// getter / setter for the Pickles
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
        /// getter / setter for the Cheese
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
        /// getter and setter for the Tomato
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
        /// getter and setter for the Lettuce
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
        /// getter and setter for the Mayo
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
        /// special instructions for the doubleDraugr
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
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
