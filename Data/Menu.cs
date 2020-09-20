/*
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

        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());

            return entree;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                side.Add(new DragonbornWaffleFries() { Size = s });
                side.Add(new FriedMiraak() { Size = s });
                side.Add(new MadOtarGrits() { Size = s });
                side.Add(new VokunSalad() { Size = s });
            }

            return side;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drink.Add(new AretinoAppleJuice() { Size = s });
                drink.Add(new CandlehearthCoffee() { Size = s, Decaf = false });
                drink.Add(new CandlehearthCoffee() { Size = s, Decaf = true });
                drink.Add(new MarkarthMilk() { Size = s });
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drink.Add(new SailorSoda() { Size = s, Flavor = sf });
                }
                drink.Add(new WarriorWater() { Size = s });
            }

            return drink;
        }


        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.AddRange(Entrees());
            menu.AddRange(Sides());
            menu.AddRange(Drinks());

            return menu;
        }


        
    }
}
