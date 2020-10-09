/*
* Author: Joshua Garcia
* Class name: MainScreen.xaml.cs
* Purpose: UserControl to display all the options on the Menu and the OrderDisplay
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : UserControl
    {
        /// <summary>
        /// Created a Dictionary to store the screen enum to a UserControl
        /// </summary>
        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        /// <summary>
        /// Initializing the UserControl
        /// </summary>
        public MainScreen()
        {
            InitializeComponent();
            menuDisplay.Ancestor = this;
            screens.Add(Screen.Menu, menuDisplay);
            screens.Add(Screen.BriarheartToppings, new BriarheartToppings(this));
            screens.Add(Screen.DoubleDraugrToppings, new DoubleDraugrToppings(this));
            screens.Add(Screen.GardenOrcOmeletteToppings, new GardenOrcOmeletteToppings(this));
            screens.Add(Screen.PhillyPoacherToppings, new PhillyPoacherToppings(this));
            screens.Add(Screen.SmokehouseSkeletonToppings, new SmokehouseSkeletonToppings(this));
            screens.Add(Screen.ThalmorTripleToppings, new ThalmorTripleToppings(this));
            screens.Add(Screen.ThugsTBoneToppings, new ThugsTBoneToppings(this));
            screens.Add(Screen.AretinoAppleJuiceOptions, new AretinoAppleJuiceOptions(this));
            screens.Add(Screen.CandlehearthCoffeeOptions, new CandlehearthCoffeeOptions(this));
            screens.Add(Screen.MarkarthMilkOptions, new MarkarthMilkOptions(this));
            screens.Add(Screen.SailorSodaOptions, new SailorSodaOptions(this));
            screens.Add(Screen.WarriorWaterOptions, new WarriorWaterOptions(this));
            screens.Add(Screen.DragonbornWaffleFriesOptions, new DragonbornWaffleFriesOptions(this));
            screens.Add(Screen.FriedMiraakOptions, new FriedMiraakOptions(this));
            screens.Add(Screen.MadOtarGritsOptions, new MadOtarGritsOptions(this));
            screens.Add(Screen.VokunSaladOptions, new VokunSaladOptions(this));

        }

        /// <summary>
        /// A Method to help create a section to switch screens
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen)
        {
            theMenu.Child = screens[screen];
        }


    }
}
