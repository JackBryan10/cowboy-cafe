/* Author: Jack Walter
 * Class Name: TexasTea.cs
 * Purpose: A class representing the Water drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water drink
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public new event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the Water drink
        /// </summary>
        public override double Price { get; } = 0.12;

        /// <summary>
        /// The calories of the Water drink
        /// </summary>
        public override uint Calories { get; } = 0;

        private bool lemon = false;
        /// <summary>
        /// Whether the Water drink is served with Lemon or not
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if (lemon == value) return;
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Whether the Water drink is served with Ice or not
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
        /// The special instructions for preparing the Water drink
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
        /// <returns>The string "*Size* Water"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
