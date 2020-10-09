/*
* Author: Joshua Garcia
* Class name: GardenOrcOmelette.xaml.cs
* Purpose: UserControl to display the options for Garden Orc Omelette
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
    /// Interaction logic for GardenOrcOmeletteToppings.xaml
    /// </summary>
    public partial class GardenOrcOmeletteToppings : UserControl
    {
        /// <summary>
        /// Creating a MainScreen Datatype to link to the parent UserControl
        /// </summary>
        MainScreen ancestor;

        /// <summary>
        /// Initializing the UserControl
        /// </summary>
        /// <param name="ancestor"></param>
        public GardenOrcOmeletteToppings(MainScreen ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        /// <summary>
        /// A Method to switch back to main menu view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.Menu);
        }

    }
}
