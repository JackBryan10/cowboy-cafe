/* Author: Jack Walter
 * Class Name: CowboyCoffee.cs
 * Purpose: A class representing the Cowboy Coffee drink
*/
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// The price of the Cowboy Coffee drink
        /// </summary>
        public override double Price 
        { 
            get 
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The calories of the Cowboy Coffee drink
        /// </summary>
        public override uint Calories 
        {
            get 
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            } 
        }

        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink is Decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink has room for Cream or not
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink has Ice or not
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// The special instructions for preparing the Cowboy Coffee drink
        /// </summary>
        public override List<string> SpecialInstructions 
        {
            get 
            {
                List<string> instructions = new List<string>();

                if (Ice) { instructions.Add("Add Ice");}
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                
                return instructions;   
            }
        }
    }
}
