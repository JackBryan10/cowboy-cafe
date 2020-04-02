/* Author: Jack Walter
 * Class Name: Drink.cs
 * Purpose: A Base class that represents a drink
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Base class that represents a drink
    /// </summary>
    public abstract class Drink: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event listener for a PropertyChangedEvent
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size {
            get { return size; }
            set
            {
                if (size == value) return;
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get;}

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets whether the drink has ice or not 
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special instuctions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions{ get; }
    }
}
