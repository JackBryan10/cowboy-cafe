/* Author: Jack Walter
 * Class Name: SideCustomization.xaml.cs
 * Purpose: A partial class for the Side Customization screen for Cowboy Cafe Point of Sale
 * **Using ideas inspired by Zachery Bruner's model solution**
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SideCustomization.xaml
    /// </summary>
    public partial class SideCustomization : UserControl
    {
        /// <summary>
        /// Private backing variable for current order
        /// </summary>
        private Order order;

        /// <summary>
        /// Constructor for the SideCustomization OrderControl
        /// </summary>
        /// <param name="dataContext"></param>
        public SideCustomization(object dataContext)
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
            Side side;

            if (DataContext is ChiliCheeseFries)
                side = (ChiliCheeseFries)DataContext;
            else if (DataContext is CornDodgers)
                side = (CornDodgers)DataContext;
            else if (DataContext is PanDeCampo)
                side = (PanDeCampo)DataContext;
            else
                side = (BakedBeans)DataContext;

            switch (((RadioButton)sender).Name)
            {
                case "ButtonSmall":
                    side.Size = Size.Small;
                    ButtonSwitch(side.Size);
                    break;
                case "ButtonMedium":
                    side.Size = Size.Medium;
                    ButtonSwitch(side.Size);
                    break;
                case "ButtonLarge":
                    side.Size = Size.Large;
                    ButtonSwitch(side.Size);
                    break;
                default:
                    break;
            }
            order.PropertiesUpdate();
        }

        /// <summary>
        /// Separates the cases of Side Size to the correct Size RadioButton to be checked
        /// </summary>
        /// <param name="size"></param>
        public void ButtonSwitch(Size size)
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
