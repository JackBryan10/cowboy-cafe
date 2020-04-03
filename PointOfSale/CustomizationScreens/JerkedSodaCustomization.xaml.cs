/* Author: Jack Walter
 * Class Name: JerkedSodaCustomization.xaml.cs
 * Purpose: A partial class for the Jerked Soda Customization screen for Cowboy Cafe Point of Sale
 * **Using ideas inspired by Zachery Bruner's model solution**
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        /// <summary>
        /// Private backing variable for current order
        /// </summary>
        private Order order;

        /// <summary>
        /// Constructor for the JerkedSodaCustomization OrderControl
        /// </summary>
        public JerkedSodaCustomization(object dataContext)
        {
            InitializeComponent();
            order = (Order)dataContext;
        }

        /// <summary>
        /// Event Handler for a click event on the Radio Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IsClicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda drink = (JerkedSoda)DataContext;
            
            switch (((RadioButton)sender).Name)
            {
                case "CreamSodaButton":
                    drink.Flavor = SodaFlavor.CreamSoda;
                    ButtonFlavorSwitch(drink.Flavor);
                    break;
                case "OrangeSodaButton":
                    drink.Flavor = SodaFlavor.OrangeSoda;
                    ButtonFlavorSwitch(drink.Flavor);
                    break;
                case "SarsparillaButton":
                    drink.Flavor = SodaFlavor.Sarsparilla;
                    ButtonFlavorSwitch(drink.Flavor);
                    break;
                case "BirchBeerButton":
                    drink.Flavor = SodaFlavor.BirchBeer;
                    ButtonFlavorSwitch(drink.Flavor);
                    break;
                case "RootBeerButton":
                    drink.Flavor = SodaFlavor.RootBeer;
                    ButtonFlavorSwitch(drink.Flavor);
                    break;

                case "ButtonSmall":
                    drink.Size = Size.Small;
                    ButtonSizeSwitch(drink.Size);
                    break;
                case "ButtonMedium":
                    drink.Size = Size.Medium;
                    ButtonSizeSwitch(drink.Size);
                    break;
                case "ButtonLarge":
                    drink.Size = Size.Large;
                    ButtonSizeSwitch(drink.Size);
                    break;
                default:
                    break;
            }
            order.PropertiesUpdate();
        }

        /// <summary>
        /// Assigns the Drink SodaFlavor to check the correct Flavor RadioButton
        /// </summary>
        /// <param name="flavor"></param>
        public void ButtonFlavorSwitch(SodaFlavor flavor) 
        {
            switch (flavor)
            {
                case SodaFlavor.CreamSoda:
                    CreamSodaButton.IsChecked = true;
                    OrangeSodaButton.IsChecked = false;
                    SarsparillaButton.IsChecked = false;
                    BirchBeerButton.IsChecked = false;
                    RootBeerButton.IsChecked = false;
                    break;
                case SodaFlavor.OrangeSoda:
                    CreamSodaButton.IsChecked = false;
                    OrangeSodaButton.IsChecked = true;
                    SarsparillaButton.IsChecked = false;
                    BirchBeerButton.IsChecked = false;
                    RootBeerButton.IsChecked = false;
                    break;
                case SodaFlavor.Sarsparilla:
                    CreamSodaButton.IsChecked = false;
                    OrangeSodaButton.IsChecked = false;
                    SarsparillaButton.IsChecked = true;
                    BirchBeerButton.IsChecked = false;
                    RootBeerButton.IsChecked = false;
                    break;
                case SodaFlavor.BirchBeer:
                    CreamSodaButton.IsChecked = false;
                    OrangeSodaButton.IsChecked = false;
                    SarsparillaButton.IsChecked = false;
                    BirchBeerButton.IsChecked = true;
                    RootBeerButton.IsChecked = false;
                    break;
                case SodaFlavor.RootBeer:
                    CreamSodaButton.IsChecked = false;
                    OrangeSodaButton.IsChecked = false;
                    SarsparillaButton.IsChecked = false;
                    BirchBeerButton.IsChecked = false;
                    RootBeerButton.IsChecked = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Separates the cases of Drink Size to the correct Size RadioButton to be checked
        /// </summary>
        /// <param name="size"></param>
        public void ButtonSizeSwitch(Size size) 
        {
            switch (size) 
            {
                case Size.Small:
                    ButtonSmall.IsChecked = true;
                    ButtonMedium.IsChecked = false;
                    ButtonLarge.IsChecked = false;
                    break;
                case Size.Medium:
                    ButtonSmall.IsChecked = false;
                    ButtonMedium.IsChecked = true;
                    ButtonLarge.IsChecked = false;
                    break;
                case Size.Large:
                    ButtonSmall.IsChecked = false;
                    ButtonMedium.IsChecked = false;
                    ButtonLarge.IsChecked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
