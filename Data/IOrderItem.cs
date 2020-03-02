/* Author: Jack Walter
 * Class Name: IOrderItem.cs
 * Purpose: An Interface for all Menu Items in the Cowboy Cafe
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface for all Menu items in Cowboy Cafe
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price of that Menu Item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the special instructions of that Menu Item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
