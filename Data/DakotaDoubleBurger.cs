/* Filename: DakotaDoubleBurger.cs
 * Author: Jack Walter
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger: Entree
    {
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// If the burger is topped with a slice of tomato
        /// </summary>
        public bool Tomato 
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// If the burger is topped with a leaf of lettuce
        /// </summary>
        public bool Lettuce 
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// If the burger is topped with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// If the burger is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the burger is topped with a slice of cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price { get { return 5.20; } }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories { get { return 464; } }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions 
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!tomato) { instructions.Add("hold tomato"); }
                if (!lettuce) { instructions.Add("hold lettuce"); }
                if (!mayo) { instructions.Add("hold mayo"); }
                if (!bun) { instructions.Add("hold bun"); }
                if (!ketchup) { instructions.Add("hold ketchup"); }
                if (!mustard) { instructions.Add("hold mustard"); }
                if (!pickle) { instructions.Add("hold pickle"); }
                if (!cheese) { instructions.Add("hold cheese"); }

                return instructions;
            }
        }
    }
}
