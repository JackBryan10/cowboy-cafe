/* Author: Jack Walter
 * Class Name: TrailBurger.cs
 * Purpose: A class representing the Trail Burger entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class TrailBurger: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            { 
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the burger is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the burger is topped with a slice of cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price { get; } = 4.50;

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories { get; } = 288; 

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bun) { instructions.Add("hold bun"); }
                if (!ketchup) { instructions.Add("hold ketchup"); }
                if (!mustard) { instructions.Add("hold mustard"); }
                if (!pickle) { instructions.Add("hold pickle"); }
                if (!cheese) { instructions.Add("hold cheese"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Trail Burger"</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
