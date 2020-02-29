/* Author: Jack Walter
 * Class Name: Order.cs
 * Purpose: A class representing the Order 
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        private uint lastOrderNumber;
        
        /// <summary>
        /// 
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal { get; set; }
        
        public uint OrderNumber { get { return lastOrderNumber++; } }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<string> Price { get { return prices.ToArray(); } }
        
        List<string> prices = new List<string>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            prices.Add(String.Format("${0:0.00}", item.Price));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            prices.Remove(String.Format("${0:0.00}", item.Price));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}
