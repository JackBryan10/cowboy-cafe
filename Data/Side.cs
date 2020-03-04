/* Author: Nathan Bean 
 * Revised by: Jack Walter
 * Class Name: Side.cs
 * Purpose: A Base class representing a side
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Throws NotImplementedException because sides have no Special Instructions
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}
