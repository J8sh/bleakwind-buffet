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

        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

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

        public void SwitchScreen(Screen screen)
        {
            theMenu.Child = screens[screen];
        }


    }
}
