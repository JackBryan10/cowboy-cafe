﻿//Using ideas from Zachery Bruner's model solution for sides
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
        /// 
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
            order.PropertiesChanged();
        }

        /// <summary>
        /// 
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
