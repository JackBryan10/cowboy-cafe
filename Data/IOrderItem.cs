/* Author: Jack Walter
 * Class Name: IOrderItem.cs
 * Purpose: An Interface for all Menu Items in the Cowboy Cafe
*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface for all Order items in Cowboy Cafe
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price of that Order Item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the special instructions of that Order Item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
