﻿/* Author: Jack Walter
 * Class Name: BakedBeans.cs
 * Purpose: A class representing a Baked Beans side
*/
using System;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Baked Beans side
    /// </summary>
    public class BakedBeans: Side
    {
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
