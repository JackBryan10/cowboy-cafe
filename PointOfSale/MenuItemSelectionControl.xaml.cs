/* Author: Jack Walter
 * Class Name: MenuItemSelectionControl.xaml.cs
 * Purpose: A partial class containing the MenuItemSelectionControl screen for Cowboy Cafe Point of Sale
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.Customization_Screens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Constructor for the MenuItemSelectionControl Order Control
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event handler for the Angry Chicken entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new AngryChicken();
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Cowboke Chili entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CowpokeChili();
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Rustler's Ribs entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new RustlersRibs();
                    var screen = new RustlersRibsCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Pecos Pulled Pork entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new PecosPulledPork();
                    var screen = new PecosPulledPorkCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Dakota Double Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new DakotaDoubleBurger();
                    var screen = new DakotaDoubleBurgerCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Trail Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TrailBurger();
                    var screen = new TrailBurgerCustomizations();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Texas Triple Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TexasTripleBurger();
                    var screen = new TexasTripleBurgerCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Baked Beans side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new BakedBeans();
                    var screen = new SideCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Chili Cheese Fries side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new ChiliCheeseFries();
                    var screen = new SideCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Corn Dodgers side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CornDodgers();
                    var screen = new SideCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Pan de Campo side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new PanDeCampo();
                    var screen = new SideCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event hander for the Cowboy Coffee drink button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new CowboyCoffee();
                    var screen = new CowboyCoffeeCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSizeSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Jerked Soda drink button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new JerkedSoda();
                    var screen = new JerkedSodaCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSizeSwitch(item.Size);
                    screen.ButtonFlavorSwitch(item.Flavor);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Texas Tea drink button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new TexasTea();
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl?.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Click event handler for the Water drink button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    var item = new Water();
                    var screen = new WaterCustomization(DataContext);
                    screen.DataContext = item;
                    data.Add(item);
                    screen.ButtonSizeSwitch(item.Size);
                    orderControl?.SwapScreen(screen);
                }
            }
        }
    }
}