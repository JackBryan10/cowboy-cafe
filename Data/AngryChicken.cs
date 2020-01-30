﻿/* Filename: CowpokeChili.cs
 * Author: Jack Walter
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// Variable to store the decision of bread or not
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If the sandwich has bread or not
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// If the sandwich has pickles or not
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }
    }

}
