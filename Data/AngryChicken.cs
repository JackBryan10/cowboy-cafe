using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an angry chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// 
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// 
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// 
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }
    }

}
