/* Author: Jack Walter
 * Class Name: BakedBeans.cs
 * Purpose: A class representing a Baked Beans side
*/
using System;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Baked Beans side
    /// </summary>
    public class BakedBeans: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the Baked Beans side
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
        /// The calories of the Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Baked Beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The string "*Size* Baked Beans"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
