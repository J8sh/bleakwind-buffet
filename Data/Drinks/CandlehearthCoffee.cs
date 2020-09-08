/*
* Author: Joshua Garcia
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent the Candlehearth Coffee in the Drinks namespace
*/

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {

        /// <summary>
        /// use ice 
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// coffee is not decaf by default
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// no room for cream by default
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// determines what size of drink
        /// </summary>
        //private Size size = Size.Small;

        /// <summary>
        /// getter/setter for ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// getter/setter for decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// getter/setter for cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// get the price value
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get the calorie amount
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// holds any special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>a string </returns>
        public override string ToString()
        {
            
            if(Decaf == true)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }

            return Size.ToString() + " Candlehearth Coffee";
        }



    }
}
