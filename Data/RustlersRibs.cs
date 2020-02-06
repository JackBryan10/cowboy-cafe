/* Filename: RustersRibs.cs
 * Author: Jack Walter
 */
using System;
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
        public override double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calories of the spare ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }

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
    }
}
