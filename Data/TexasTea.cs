/* Author: Jack Walter
 * Class Name: TexasTea.cs
 * Purpose: A class representing the Texas Tea drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool lemon = false;
        private bool ice = true;
        
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
        /// Whether the Texas Tea drink is sweet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether the Water drink is served with Ice or not
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Whether the Texas Tea drink is served with Lemon or not
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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

        /// <summary>
        /// Returns the string representation of the drink
        /// </summary>
        /// <returns>The string "*Size* *Decaf* Cowboy Coffee"</returns>
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
            sb.Append("Texas ");
            if (Sweet) { sb.Append("Sweet "); }
            else { sb.Append("Plain "); }
            sb.Append("Tea");
            return sb.ToString();
        }
    }
}
