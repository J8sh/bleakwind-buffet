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

        public Menu()
        {
            InitializeComponent();
        }


        void BriarheartEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.BriarheartToppings);
        }

        void DoubleDraugrEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DoubleDraugrToppings);
        }

        void ThalmorTripleEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThalmorTripleToppings);
        }

        void SmokehouseSkeletonEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SmokehouseSkeletonToppings);
        }

        void GardenOrcOmletteEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.GardenOrcOmeletteToppings);
        }
        
        void ThugsTBoneEntree(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThugsTBoneToppings);
        }
        void SalorSodaDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SailorSodaOptions);
        }

        void MarkathMilkDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MarkarthMilkOptions);
        }
        void AretinoAppleJuiceDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.AretinoAppleJuiceOptions);
        }

        void CandlehearthCoffeeDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.CandlehearthCoffeeOptions);
        }
        void WarriorWaterDrink(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.WarriorWaterOptions);
        }

        void VokunSaladSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.VokunSaladOptions);
        }

        void FriedMiraakSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.FriedMiraakOptions);
        }

        void MadOtarGritsSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MadOtarGritsOptions);
        }

        void DragonbornWaffleFriesSide(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DragonbornWaffleFriesOptions);
        }


    }
}
