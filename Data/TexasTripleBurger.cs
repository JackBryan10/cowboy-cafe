/* Author: Jack Walter
 * Class Name: TexasTripleBurger.cs
 * Purpose: A class representing a Texas Triple Burger entree
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (bun == value) return;
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (ketchup == value) return;
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (mustard == value) return;
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger is topped with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (pickle == value) return;
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the burger is topped with a slice of cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (cheese == value) return;
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger is topped with a slice of tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (tomato == value) return;
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with a leaf of lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (lettuce == value) return;
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (lettuce == value) return;
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger is topped with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (bacon == value) return;
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger is topped with egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (egg == value) return;
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price { get; } = 6.45;

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories { get; } = 698;

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
                if (!tomato) { instructions.Add("hold tomato"); }
                if (!lettuce) { instructions.Add("hold lettuce"); }
                if (!mayo) { instructions.Add("hold mayo"); }
                if (!bacon) { instructions.Add("hold bacon"); }
                if (!egg) { instructions.Add("hold egg"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Texas Triple Burger"</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
