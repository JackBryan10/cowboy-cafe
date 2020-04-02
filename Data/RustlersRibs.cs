/* Author: Jack Walter
 * Class Name: RustlersRibs.cs
 * Purpose: A class representing the Rustler's Ribs entree
*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// The price of the spare ribs
        /// </summary>
        public override double Price { get; } = 7.50;

        /// <summary>
        /// The calories of the spare ribs
        /// </summary>
        public override uint Calories { get; } = 894; 
        
        /// <summary>
        /// Special instructions for the preparation of the spare ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Rustler's Ribs"</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
