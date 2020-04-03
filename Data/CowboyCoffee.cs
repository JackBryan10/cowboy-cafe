/* Author: Jack Walter
 * Class Name: CowboyCoffee.cs
 * Purpose: A class representing the Cowboy Coffee drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public new event PropertyChangedEventHandler PropertyChanged;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

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

        private bool decaf = false;
        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink is Decaf or not
        /// </summary>
        public bool Decaf 
        {
            get { return decaf; }
            set
            {
                if (decaf == value) return;
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            } 
        }

        private bool roomForCream = false;
        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink has room for Cream or not
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (roomForCream == value) return;
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = false;
        /// <summary>
        /// Gets and sets whether the Cowboy Coffee drink has Ice or not
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
        /// The special instructions for preparing the Cowboy Coffee drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (ice) { instructions.Add("Add Ice"); }
                if (roomForCream) { instructions.Add("Room for Cream"); }

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
            sb.Append(Size.ToString() + " ");
            if (Decaf) { sb.Append("Decaf "); }
            sb.Append("Cowboy Coffee");
            return sb.ToString();
        }
    }
}
