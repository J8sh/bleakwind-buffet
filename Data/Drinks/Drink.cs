﻿/*
* Author: Nathan Bean
* Modified by: Joshua Garcia
* Class name: Drink.cs
* Purpose: Class used to represent the base file for all drinks
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In Us Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        /// <value> 
        /// In uint data type
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


    }
}
