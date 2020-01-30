/* Filename: PecosPulledPork.cs
 * Author: Jack Walter
 */

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// If the sandwich is topped with bread
        /// </summary>
        public bool Bread 
        { 
            get { return bread; } 
            set { bread = value; } 
        }

        /// <summary>
        /// If the sandwich is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public uint Calories { get { return 528; } }

        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public double Price { get { return 5.88; } }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if (!pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }
    }
}
