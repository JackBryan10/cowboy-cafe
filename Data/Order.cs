/* Author: Jack Walter
 * Class Name: Order.cs
 * Purpose: A class representing the data stored in an Order 
 * and handles the actions of adding to or removing from the Order.
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Order class handling the actions taken in an order in the Point of Sale
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the order number for the previous order
        /// </summary>
        private uint lastOrderNumber;
        
        /// <summary>
        /// Stores the order number for the current order
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber++; } }

        /// <summary>
        /// Private backing variable for the items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Gets an array representation of the menu items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Gets the Subtotal of the order
        /// </summary>
        public double Subtotal { get; set; }
        
        /// <summary>
        /// An event listener for a PropertyChangedEvent
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds an IOrderItem to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);

            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChanged;
            }

            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// Removes and IOrderItem from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);

            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// Is called whenever an item is Added or Removed from the Order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemChanged(object sender, PropertyChangedEventArgs e) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if(e.PropertyName == "Price") 
            { 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); 
            }
            
        }
    }
}
