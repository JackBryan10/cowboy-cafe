/* Author: Jack Walter
 * Class Name: MainWindow.xaml.cs
 * Purpose: A partial class containing the Main Window for Cowboy Cafe Point of Sale
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the Main Window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            var data = new Order();
            this.DataContext = data;
        }

        /// <summary>
        /// Click event handler for the Cancel Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Click event handler for the Complete Order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Click event handler for the Item Selection button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
