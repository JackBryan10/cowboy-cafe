/* Author: Jack Walter
 * Class Name: Drink.cs
 * Purpose: A Base class that represents a drink
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Base class that represents a drink
    /// </summary>
    public abstract class Drink: IOrderItem
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get;}

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets whether the drink has ice or not 
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special instuctions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions{ get; }
    }
}
