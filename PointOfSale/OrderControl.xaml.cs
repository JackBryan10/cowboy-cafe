/* Author: Jack Walter
 * Class Name: OrderControl.xaml.cs
 * Purpose: A partial class containing the Order Control for Cowboy Cafe Point of Sale
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

        public void OnMenuItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
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

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
