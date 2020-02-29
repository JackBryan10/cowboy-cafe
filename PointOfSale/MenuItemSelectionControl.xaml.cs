/* Author: Jack Walter
 * Class Name: MenuItemSelectionControl.xaml.cs
 * Purpose: A partial class containing the MenuItemSelectionControl for Cowboy Cafe Point of Sale
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
            /// <summary>
            /// Constructor for the MenuItemSelectionControl User Interface
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new AngryChicken());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CowpokeChili());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new RustlersRibs());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new PecosPulledPork());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new DakotaDoubleBurger());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TrailBurger());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TexasTripleBurger());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new BakedBeans());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new ChiliCheeseFries());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CornDodgers());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new PanDeCampo());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CowboyCoffee());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new JerkedSoda());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TexasTea());
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
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new Water());
                    }
                }
            }
    }
}

