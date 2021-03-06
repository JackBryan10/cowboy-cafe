﻿/* Author: Jack Walter
 * Class Name: AngryChicken.cs
 * Purpose: A class representing an Angry Chicken entree
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangedEventHandler to notify that a property has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the sandwich has bread or not
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                if (bread == value) return;
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the sandwich has pickles or not
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

        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public override double Price { get; } = 5.99;

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public override uint Calories { get; } = 190;

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Angry Chicken"</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }

}
