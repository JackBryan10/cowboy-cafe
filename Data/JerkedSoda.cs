/* Author: Jack Walter
 * Class Name: JerkedSoda.cs
 * Purpose: A class representing the Jerked Soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;

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

        /// <summary>
        /// Returns the string representation of the drink
        /// </summary>
        /// <returns>The string "*Size* *Flavor* Cowboy Coffee"</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Size)
            {
                case Size.Large:
                    sb.Append("Large ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Small:
                    sb.Append("Small ");
                    break;
                default:
                    throw new NotImplementedException("Unknown Size");
            }
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    sb.Append("Birch Beer ");
                    break;
                case SodaFlavor.CreamSoda:
                    sb.Append("Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append("Orange Soda ");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append("Root Beer ");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append("Sarsparilla ");
                    break;
                default:
                    throw new NotImplementedException("Unknown Flavor");
            }
            sb.Append("Jerked Soda");
            return sb.ToString();
        }
    }
}
