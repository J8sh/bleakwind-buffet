/*
 * Author: Joshua Garcia
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
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
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
            }
        }

        /// <summary>
        /// get the bool for the Onion
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
            }
        }

        /// <summary>
        /// get the bool for the Roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
            }
        }

        /// <summary>
        /// price for the Philly Poacher
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// get the calories for the philly poacher
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// get the special instructions for the Philly Poacher
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
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
