/*
* Author: Joshua Garcia
* Class name: IOrderItem.cs
* Purpose: Interface used to represent the Price, Calories, and SpecialInstructions namespace
*/

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface for items with Price, Calories, SpecialInstructions
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// get price of item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// get the calories of item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// get any special instructions from the item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
