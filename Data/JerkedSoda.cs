/* Author: Jack Walter
 * Class Name: JerkedSoda.cs
 * Purpose: A class representing the Jerked Soda drink
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// The price of the Jerked Soda drink
        /// </summary>
        public override double Price 
        { 
            get 
            {
                switch (Size) 
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            } 
        }

        /// <summary>
        /// The calories of the Jerked Soda drink
        /// </summary>
        public override uint Calories 
        {
            get 
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Gets and sets the flavor of the Jerked Soda drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// The special instructions for preparing the Jerked Soda drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }

                return instructions;
            }
        }
    }
}
