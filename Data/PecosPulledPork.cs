/* Author: Jack Walter
 * Class Name: PecosPulledPork.cs
 * Purpose: A class representing the Pecos Pulled Pork entree
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
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
        public override uint Calories { get { return 528; } }

        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public override double Price { get { return 5.88; } }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if (!pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
