/* Filename: Entree.cs
 * Author: Jack Walter
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree
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
