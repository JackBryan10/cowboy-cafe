/* Author: Jack Walter
 * Class Name: Index.cshtml.cs
 * Purpose: Stores the search values and calls the respective methods to filter the menu items
*/
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CowboyCafe.Data;

namespace Website.Pages
{
    /// <summary>
    /// Stores the search values and calls the respective methods to filter the menu items
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Gets and sets the list of Menu items to display
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets and sets the categories to filter
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets and sets the value for the minimun calorie filter
        /// </summary>
        [BindProperty]
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the value for the maximum calorie filter
        /// </summary>
        [BindProperty]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the value for the minimum price filter
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the value for the maximum price filter
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets the initial results for display
        /// </summary>
        public void OnGet()
        {
            Items = Menu.CompleteMenu();
            Items = Menu.Search(Items, SearchTerms);
        }

        /// <summary>
        /// Posts the search results for display on the page
        /// </summary>
        public void OnPost()
        {
            Items = Menu.CompleteMenu();
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
