/* Author: Jack Walter
 * Class Name: TexasTea.cs
 * Purpose: A class representing the Texas Tea drink
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// The price of the Texas Tea drink
        /// </summary>
        public override double Price 
        { get 
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            } 
        }

        /// <summary>
        /// The calories of the Texas Tea drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        if (Sweet) { return 36; }
                        else { return 18; }
                    case Size.Medium:
                        if (Sweet) { return 22; }
                        else { return 11; }
                    case Size.Small:
                        if (Sweet) { return 10; }
                        else { return 5; }
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Whether the Texas Tea drink is Sweet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether the Texas Tea drink is served with Lemon or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The special instructions for preparing the Texas Tea drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }

                return instructions;
            }
        }
    }
}
