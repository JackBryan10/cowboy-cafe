/* Author: Jack Walter
 * Class Name: OrderControl.xaml.cs
 * Purpose: A partial class containing the Order Control for Cowboy Cafe Point of Sale
*/
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor for the OrderControl User Interface
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event handler for the Cancel Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        /// <summary>
        /// Click event handler for the Complete Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        /// <summary>
        /// Click event handler for the Item Selection button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Swaps the Windows 
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
