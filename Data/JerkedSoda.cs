/* Author: Jack Walter
 * Class Name: JerkedSoda.cs
 * Purpose: A class representing the Jerked Soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public new event PropertyChangedEventHandler PropertyChanged;

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

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the Jerked Soda drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                if (size == value) return;
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// Gets and sets the flavor of the Jerked Soda drink
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                if (flavor == value) return;
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Gets and sets whether the Jerked Soda drink has Ice or not
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if (ice == value) return;
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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
        /// <returns>The string "*Size* *Flavor* Jerked Soda"</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString());
            switch (flavor)
            {
                case SodaFlavor.CreamSoda:
                    sb.Append(" Cream Soda");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append(" Orange Soda");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append(" Sarsparilla");
                    break;
                case SodaFlavor.BirchBeer:
                    sb.Append(" Birch Beer");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append(" Root Beer");
                    break;
                default:
                    break;
            }
            sb.Append(" Jerked Soda");
            return sb.ToString();
        }
    }
}
