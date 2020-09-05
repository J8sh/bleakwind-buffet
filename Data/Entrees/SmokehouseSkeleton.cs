/*
 * Author: Joshua Garcia
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smoke house Skeleton in the Entrees namespace
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// sausage links are included by default
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// eggs are included by default
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// hash browns are included by default
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// pancakes are included by default
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// get bool of sausage links
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// get bool of egg 
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
        /// get bool of hashBrowns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// get bool of pancakes
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
            }
        }

        /// <summary>
        /// get Price of Smoke house Skeleton
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }
        }
        
        /// <summary>
        /// get Calories for the Smoke house Skeleton
        /// </summary>
        public uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// get the special instructions for the Smoke house Skeleton
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// ToString Method to override ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }



    }
}
