/*
* Author:Joshua Garcia
* Class name: Entree.cs
* Purpose: Class used to represent the base file for all Entrees
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In Us Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        /// <value> 
        /// In uint data type
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        uint IOrderItem.Calories()
        {
            throw new NotImplementedException();
        }

        double IOrderItem.Price()
        {
            throw new NotImplementedException();
        }

        List<string> IOrderItem.SpecialInstructions()
        {
            throw new NotImplementedException();
        }
    }
}
