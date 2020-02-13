/* Author: Jack Walter
 * Class Name: Drink.cs
 * Purpose: A Base class representing drink
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Base class representing drink
    /// </summary>
    public abstract class Drink
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
