/* Author: Jack Walter
 * Class Name: MainWindow.xaml.cs
 * Purpose: A partial class containing the Main Window for Cowboy Cafe Point of Sale
*/
using System.Windows;
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
            var order = new Order();
            this.DataContext = order;
        }
    }
}
