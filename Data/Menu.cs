/* Author: Jack Walter
 * Class Name: Menu.cs
 * Purpose: Creates IEnumberable lists of individual IOrderItems or 
 *          all IOrderItems on the CowboyCafe Menu
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Creates IEnumberable lists of individual IOrderItems or all 
    /// IOrderItems on the CowboyCafe Menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates an IEnumerable list containing a single instance of every Entree
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every Entree</returns>
        public static IEnumerable<IOrderItem> Entrees() 
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new AngryChicken());
            list.Add(new CowpokeChili());
            list.Add(new PecosPulledPork());
            list.Add(new RustlersRibs());
            list.Add(new TrailBurger());
            list.Add(new DakotaDoubleBurger());
            list.Add(new TexasTripleBurger());

            return list;
        }

        /// <summary>
        /// Creates an IEnumerable list containing a single instance of every Side
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every Side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new BakedBeans());
            list.Add(new ChiliCheeseFries());
            list.Add(new CornDodgers());
            list.Add(new PecosPulledPork());

            return list;
        }

        /// <summary>
        /// Creates an IEnumerable list containing a single instance of every Drink
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every Side</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new CowboyCoffee());
            list.Add(new JerkedSoda());
            list.Add(new TexasTea());
            list.Add(new Water());

            return list;
        }

        /// <summary>
        /// Creates an IEnumerable list containing a single instance of every IOrderItem
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every IOrderItem</returns>
        public static IEnumerable<IOrderItem> CompleteMenu() 
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach(IOrderItem item in Entrees()) 
            {
                list.Add(item);
            }
            foreach (IOrderItem item in Sides())
            {
                list.Add(item);
            }
            foreach (IOrderItem item in Drinks())
            {
                list.Add(item);
            }
            return list;
        }
    }
}
