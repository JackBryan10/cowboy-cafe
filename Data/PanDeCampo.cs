/* Author: Jack Walter
 * Class Name: PanDeCampo.cs
 * Purpose: A class representing the Pan de Campo side
*/
using System;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the Pan de Campo side
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
        /// The calories of the Pan de Campo bread
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// The price of the Pan de Campo bread
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
        /// <returns>The string "*Size* Pan de Campo"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
