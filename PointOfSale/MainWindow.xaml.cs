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
using PointOfSale.Customization_Screens;

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
