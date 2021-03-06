﻿/*
* Author: Joshua Garcia
* Class name: Side.cs
* Purpose: Class used to represent the base file for all sides
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In Us Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        /// <value> 
        /// In uint data type
        /// </value>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
