/* Author: Jack Walter
 * Class Name: Order.cs
 * Purpose: A class representing the data stored in an Order 
 * and handles the actions of adding items, removing items, and updating the Order.
*/
using System.Collections.Generic;
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
        public static uint LastOrderNumber = 0;

        /// <summary>
        /// Stores the order number for the current order
        /// </summary>
        public uint OrderNumber { get; set; }

        /// <summary>
        /// Private backing variable for the items in the order
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// Gets an array representation of the menu items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Gets the Subtotal price before tax of the order
        /// </summary>
        public double Subtotal { get; set; }

        /// <summary>
        /// Gets the Total price after tax of the order
        /// </summary>
        public double Total { get; set; }
        
        /// <summary>
        /// An event listener for a PropertyChangedEvent
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for the Order class
        /// </summary>
        public Order() 
        {
            items = new List<IOrderItem>();
            OrderNumber = LastOrderNumber++;
        }

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
            Total = Subtotal * 1.16;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
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
            Total = Subtotal * 1.16;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
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

        /// <summary>
        /// Updates the item when a property's Size or Flavor is changed 
        /// </summary>
        public void PropertiesUpdate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            Subtotal = 0;
            foreach(IOrderItem item in items) 
            {
                Subtotal += item.Price;
                Total = Subtotal * 1.16;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
