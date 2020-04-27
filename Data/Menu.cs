/* Author: Jack Walter
 * Class Name: Menu.cs
 * Purpose: Creates Lists of individual IOrderItems or all IOrderItems on the CowboyCafe Menu & 
 *          searches and filters through the list 
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Creates Lists of individual IOrderItems or all IOrderItems on the CowboyCafe Menu & 
    /// searches and filters through the list
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the possible Categories 
        /// </summary>
        public static string[] Categories
        {
            get => new string[] { "Entrees", "Sides", "Drinks" };
        }

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
        /// Creates an IEnumerable list containing a single instance of every Side and size
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every Side and size</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                BakedBeans beans = new BakedBeans();
                beans.Size = size;
                list.Add(beans);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                ChiliCheeseFries fries = new ChiliCheeseFries();
                fries.Size = size;
                list.Add(fries);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                CornDodgers dodger = new CornDodgers();
                dodger.Size = size;
                list.Add(dodger);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                PanDeCampo campo = new PanDeCampo();
                campo.Size = size;
                list.Add(campo);
            }

            return list;
        }

        /// <summary>
        /// Creates an IEnumerable list containing a single instance of every Drink and size
        /// </summary>
        /// <returns>An IEnumerable list containing a single instance of every Drink and size</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                CowboyCoffee coffee = new CowboyCoffee();
                coffee.Size = size;
                list.Add(coffee);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                JerkedSoda soda = new JerkedSoda();
                soda.Size = size;
                list.Add(soda);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                TexasTea tea = new TexasTea();
                tea.Size = size;
                list.Add(tea);
            }
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                Water water = new Water();
                water.Size = size;
                list.Add(water);
            }
            return list;
        }

        /// <summary>
        /// Creates a list containing a instance of every type of IOrderItem
        /// </summary>
        /// <returns>List containing a instance of every type of IOrderItem</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach (IOrderItem item in Entrees())
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

        /// <summary>
        /// Searches for whether a matching string exists in the list of menu items
        /// </summary>
        /// <param name="items">Unfiltered List of menu items</param>
        /// <param name="terms">String of search terms</param>
        /// <returns>Filtered list of menu items</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            categoryList = new List<string>();
            itemList = new List<string>();

            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return items;

            foreach (IOrderItem item in items)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list of menu items by the Categories selected
        /// </summary>
        /// <param name="items">Unfiltered List of menu items</param>
        /// <param name="categories">Categories specified to display</param>
        /// <returns>Filtered list of menu items</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) { return items; }

            categoryList = new List<string>();
            itemList = new List<string>();

            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (item is Entree && categories.Contains("Entrees"))
                {
                    results.Add(item);
                }
                else if (item is Side && categories.Contains("Sides"))
                {
                    results.Add(item);
                }
                else if (item is Drink && categories.Contains("Drinks"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list of menu items by the specified Calorie range 
        /// </summary>
        /// <param name="items">Unfiltered List of menu items</param>
        /// <param name="min">Minimum specified value of calories</param>
        /// <param name="max">Maximum specified value of calories</param>
        /// <returns>Filtered list of menu items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            categoryList = new List<string>();
            itemList = new List<string>();

            // neither a maximum nor minimum specified
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list of menu items by the specified Price range 
        /// </summary>
        /// <param name="items">Unfiltered List of menu items</param>
        /// <param name="min">Minimum specified price value</param>
        /// <param name="max">Maximum specified price value</param>
        /// <returns>Filtered list of menu items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            categoryList = new List<string>();
            itemList = new List<string>();

            // neither a maximum nor minimum specified
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// List of types of categories that exist within the filtered menu
        /// </summary>
        private static List<string> categoryList = new List<string>();

        /// <summary>
        /// Determines whether the list already contains the header for the Category (for Displaying purposes)
        /// </summary>
        /// <param name="item">Item to evaluate</param>
        /// <returns>Boolean value</returns>
        public static bool AlreadyContainsCategory(IOrderItem item)
        {
            if (item is Entree)
            {
                if (categoryList.Contains("Entree")) { return true; }
                else
                {
                    categoryList.Add("Entree");
                    return false;
                }
            }
            if (item is Side)
            {
                if (categoryList.Contains("Side")) { return true; }
                else
                {
                    categoryList.Add("Side");
                    return false;
                }
            }
            if (item is Drink)
            {
                if (categoryList.Contains("Drink")) { return true; }
                else
                {
                    categoryList.Add("Drink");
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// List of types of drinks and sides that exist within the filtered menu
        /// </summary>
        private static List<string> itemList = new List<string>();

        /// <summary>
        /// Determines whether the list already contains the header for the Drink and Side classes (for Displaying purposes)
        /// </summary>
        /// <param name="item">Item to evaluate</param>
        /// <returns>Boolean value</returns>
        public static bool AlreadyContainsItemType(IOrderItem item)
        {
            if (item is Side side)
            {
                if (side is BakedBeans)
                {
                    if (itemList.Contains("Beans")) { return true; }
                    else
                    {
                        itemList.Add("Beans");
                        return false;
                    }
                }
                if (side is CornDodgers)
                {
                    if (itemList.Contains("Dodgers")) { return true; }
                    else
                    {
                        itemList.Add("Dodgers");
                        return false;
                    }
                }
                if (side is ChiliCheeseFries)
                {
                    if (itemList.Contains("Fries")) { return true; }
                    else
                    {
                        itemList.Add("Fries");
                        return false;
                    }
                }
                if (side is PanDeCampo)
                {
                    if (itemList.Contains("Campo")) { return true; }
                    else
                    {
                        itemList.Add("Campo");
                        return false;
                    }
                }
            }
            if (item is Drink drink)
            {
                if (drink is CowboyCoffee)
                {
                    if (itemList.Contains("Coffee")) { return true; }
                    else
                    {
                        itemList.Add("Coffee");
                        return false;
                    }
                }
                if (drink is JerkedSoda)
                {
                    if (itemList.Contains("Soda")) { return true; }
                    else
                    {
                        itemList.Add("Soda");
                        return false;
                    }
                }
                if (drink is TexasTea)
                {
                    if (itemList.Contains("Tea")) { return true; }
                    else
                    {
                        itemList.Add("Tea");
                        return false;
                    }
                }
                if (drink is Water)
                {
                    if (itemList.Contains("Water")) { return true; }
                    else
                    {
                        itemList.Add("Water");
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
