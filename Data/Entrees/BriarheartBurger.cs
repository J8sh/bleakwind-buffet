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

    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// property for the burger price
        /// </summary>
        public override double Price
        {
            get { return 6.32;  }
        }
        
        /// <summary>
        /// property for the Calorie total
        /// </summary>
        public override uint Calories 
        {
            get { return 743; }
        }

        /// <summary>
        /// bool to include bun
        /// </summary>
        private bool bun = true;

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
        /// bool to include ketchup
        /// </summary>
        private bool ketchup = true;

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
        /// bool to include mustard
        /// </summary>
        private bool mustard = true;

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
        /// bool to include pickles
        /// </summary>
        private bool pickle = true;

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
        /// bool to include cheese
        /// </summary>
        private bool cheese = true;

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
        /// special instructions for the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
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
