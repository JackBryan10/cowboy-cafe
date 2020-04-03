/* Author: Jack Walter
 * Class Name: CowboyCoffeeCustomization.xaml.cs
 * Purpose: A partial class for the Cowboy Coffee Customization screen for Cowboy Cafe Point of Sale
 * **Using ideas inspired by Zachery Bruner's model solution**
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for CowboyCoffeeCustomization.xaml
    /// </summary>
    public partial class CowboyCoffeeCustomization : UserControl
    {
        /// <summary>
        /// Private backing variable for current order
        /// </summary>
        private Order order;

        /// <summary>
        /// Constructor for the CowboyCoffeeCustomization Order Control
        /// </summary>
        public CowboyCoffeeCustomization(object dataContext)
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
            CowboyCoffee drink = (CowboyCoffee)DataContext;

            switch (((RadioButton)sender).Name)
            {
                case "ButtonDecaf":
                    if (drink.Decaf) 
                    { 
                        drink.Decaf = false;
                        ButtonDecaf.IsChecked = false;
                    }
                    else 
                    {
                        drink.Decaf = true;
                        ButtonDecaf.IsChecked = true;
                    }
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
