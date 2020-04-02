/* Author: Jack Walter
 * Class Name: OrderSummaryControl.xaml.cs
 * Purpose: A partial class containing the OrderSummaryControl for Cowboy Cafe Point of Sale
*/
using System.Windows.Controls;
using System.Windows;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.Customization_Screens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Constructor for the OrderSummaryControl class
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for when the Item is removed from the OrderSummaryControl screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        data.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Private backing variable for the Order Control
        /// </summary>
        private OrderControl orderControl;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionClicked(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem item)
                {
                    /*********************Entree Selection*********************/
                    if (item is AngryChicken angry)
                    {
                        var screen = new AngryChickenCustomization();
                        screen.DataContext = angry;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen); 
                    }
                    if (item is CowpokeChili cowpoke)
                    {
                        var screen = new CowpokeChiliCustomization();
                        screen.DataContext = cowpoke;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is RustlersRibs rustlers)
                    {
                        var screen = new RustlersRibsCustomization();
                        screen.DataContext = rustlers;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is PecosPulledPork pecos)
                    {
                        var screen = new PecosPulledPorkCustomization();
                        screen.DataContext = pecos;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is DakotaDoubleBurger dakota)
                    {
                        var screen = new DakotaDoubleBurgerCustomization();
                        screen.DataContext = dakota;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TrailBurger trail)
                    {
                        var screen = new TrailBurgerCustomizations();
                        screen.DataContext = trail;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TexasTripleBurger texas)
                    {
                        var screen = new TexasTripleBurgerCustomization();
                        screen.DataContext = texas;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl?.SwapScreen(screen);
                    }

                    /*********************Side Selection*********************/
                    if (item is BakedBeans baked)
                    {
                        var screen = new SideCustomization(DataContext);
                        screen.DataContext = baked;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSwitch(baked.Size);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is ChiliCheeseFries chili)
                    {
                        var screen = new SideCustomization(DataContext);
                        screen.DataContext = chili;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSwitch(chili.Size);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is CornDodgers corn)
                    {
                        var screen = new SideCustomization(DataContext);
                        screen.DataContext = corn;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSwitch(corn.Size);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is PanDeCampo pan)
                    {
                        var screen = new SideCustomization(DataContext);
                        screen.DataContext = pan;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSwitch(pan.Size);
                        orderControl?.SwapScreen(screen);
                    }

                    /*********************Drink Selection*********************/
                    if (item is CowboyCoffee cowboy)
                    {
                        var screen = new CowboyCoffeeCustomization(DataContext);
                        screen.DataContext = cowboy;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSizeSwitch(cowboy.Size);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is JerkedSoda jerked)
                    {
                        var screen = new JerkedSodaCustomization(DataContext);
                        screen.DataContext = jerked;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSizeSwitch(jerked.Size);
                        screen.ButtonFlavorSwitch(jerked.Flavor);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is Water water)
                    {
                        var screen = new WaterCustomization(DataContext);
                        screen.DataContext = water;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSizeSwitch(water.Size);
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TexasTea texas)
                    {
                        var screen = new TexasTeaCustomization(DataContext);
                        screen.DataContext = texas;
                        orderControl = this.FindAncestor<OrderControl>();
                        screen.ButtonSizeSwitch(texas.Size);
                        orderControl?.SwapScreen(screen);
                    }
                }
            }
        }
    }
}

