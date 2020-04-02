/* Author: Jack Walter
 * Class Name: Entree.cs
 * Purpose: A Base class that represents an entree
*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Base class that represents an entree 
    /// </summary>
    public abstract class Entree: IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get;}

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get;}

        /// <summary>
        /// Gets the special instuctions for the entree
        /// </summary> 
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
