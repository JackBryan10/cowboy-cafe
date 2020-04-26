using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet()
        {
            Items = Menu.CompleteMenu();
            Items = Menu.Search(Items, SearchTerms);
        }

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
