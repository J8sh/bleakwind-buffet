/*
* Author: Joshua Garcia
* Class name: Menu.xaml.cs
* Purpose: UserControl to display the buttons for each menu items
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {

        /// <summary>
        /// The ancestor of this control
        /// </summary>
        public MainScreen Ancestor { get; set; }

        /// <summary>
        /// Initializing the UserControl
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.BriarheartToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DoubleDraugrToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThalmorTripleToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SmokehouseSkeletonToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmletteEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.GardenOrcOmeletteToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThugsTBoneToppings);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SalorSodaDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SailorSodaOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkathMilkDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MarkarthMilkOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.AretinoAppleJuiceOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.CandlehearthCoffeeOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.WarriorWaterOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.VokunSaladOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.FriedMiraakOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MadOtarGritsOptions);
        }

        /// <summary>
        /// A Method used to switch dislay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DragonbornWaffleFriesOptions);
        }


    }
}
