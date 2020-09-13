﻿/*
* Author: Joshua Garcia
* Class name: Menu.cs
* Purpose: Static file used to represent the static methods of entrees(), Sides(), Drinks()
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class for all the foods and drinks on the menu
    /// </summary>
    public static class Menu
    {

        static IEnumerable<IOrderItem> Entrees()
        {
            return Entree.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
