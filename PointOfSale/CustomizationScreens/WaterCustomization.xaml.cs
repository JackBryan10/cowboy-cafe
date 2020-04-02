/* Author: Jack Walter
 * Class Name: WaterCustomization.xaml.cs
 * Purpose: A partial class for the Water Customization screen for Cowboy Cafe Point of Sale
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for WaterCustomization.xaml
    /// </summary>
    public partial class WaterCustomization : UserControl
    {
        /// <summary>
        /// Private backing variable for current order
        /// </summary>
        private Order order;

        /// <summary>
        /// Constructor for the WaterCustomization Order Control
        /// </summary>
        public WaterCustomization(object dataContext)
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
            Water drink = (Water)DataContext;

            switch (((RadioButton)sender).Name)
            {
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
            order.PropertiesChanged();
        }

        /// <summary>
        /// Separates the cases of size to the correct button to be selected
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
