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
        public bool SausageLink { get; }

        /// <summary>
        /// get bool of egg 
        /// </summary>
        public bool Egg { get; }

        /// <summary>
        /// get bool of hashBrowns
        /// </summary>
        public bool HashBrowns { get; }

        /// <summary>
        /// get bool of pancakes
        /// </summary>
        public bool Pancake { get; }

        /// <summary>
        /// get Price of Smoke house Skeleton
        /// </summary>
        public double Price { get; }
        
        /// <summary>
        /// get Calories for the Smoke house Skeleton
        /// </summary>
        public uint Calories { get; }
        
        /// <summary>
        /// get the special instructions for the Smoke house Skeleton
        /// </summary>
        public List<String> SpecialInstructions { get; }

        /// <summary>
        /// special instructions for the SpecialInstructions list
        /// </summary>
        String[] Instructions = { "Hold sausage", "Hold eggs", "Hold hash browns", "Hold pancakes" };

        /// <summary>
        /// constructor with price and calories set
        /// </summary>
        public SmokehouseSkeleton()
        {
            this.Price = 5.62;
            this.Calories = 602;

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
