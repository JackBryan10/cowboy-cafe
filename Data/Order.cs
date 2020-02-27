/* Author: Jack Walter
 * Class Name: Order.cs
 * Purpose: A class 
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
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal => 0;

        /// <summary>
        /// 
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
