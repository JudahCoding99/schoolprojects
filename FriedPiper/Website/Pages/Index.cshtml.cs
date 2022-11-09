using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;

namespace Website.Pages
{
    /// <summary>
    /// Used to implement "events" in the HTML
    /// </summary>
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        /*public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }*/

        /// <summary>
        /// All the Menu Items on the Menu 
        /// </summary>
        public IEnumerable<IMenuItem> MenuItems { get; protected set; }

        /// <summary>
        /// All the treat items on the menu
        /// </summary>
        public IEnumerable<IMenuItem> TreatItems { get; protected set; }

        /// <summary>
        /// All the popper items on the menu
        /// </summary>
        public IEnumerable<IMenuItem> PopperItems { get; protected set; }

        /// <summary>
        /// All the platter items on the menu
        /// </summary>
        public IEnumerable<IMenuItem> PlatterItems { get; protected set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The different types of poppers
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] MenuTypes { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? CalorieMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? CalorieMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PriceMax { get; set; }

        /// <summary>
        /// Used when running a GET Request
        /// </summary>
        /// <remarks>Everytime the search button is clicked the Full Menu is reset 
        /// and the Onget( is called to filter through the menu again</remarks>
        public void OnGet()
        {
            MenuItems = Menu.FullMenu;
            TreatItems = Menu.Treats;
            PopperItems = Menu.Poppers;
            PlatterItems = Menu.Platters;
            if (SearchTerms != null)
            {
                MenuItems = MenuItems.Where(mitem => mitem.Name != null &&
                mitem.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            if (PriceMin != null && PriceMax != null)
            {
                MenuItems = MenuItems.Where(mitem =>  mitem.Price <= PriceMax);
                MenuItems = MenuItems.Where(mitem =>  mitem.Price >= PriceMin);
            }

            if (CalorieMin != null && CalorieMax != null)
            {
                MenuItems = MenuItems.Where(mitem => mitem.Calories <= CalorieMax);
                MenuItems = MenuItems.Where(mitem => mitem.Calories >= CalorieMin);
            }

            if(MenuTypes != null && MenuTypes.Length != 0)
            {
                if (MenuTypes.Contains("Treats") && MenuTypes.Length == 1)
                {
                    MenuItems = MenuItems.Where(mitem => !(mitem is Popper) && !(mitem is PopperPlatter) && !(mitem is PiperPlatter));
                }else if(MenuTypes.Contains("Treats") && MenuTypes.Length == 2)
                {
                    if (MenuTypes.Contains("Poppers"))
                    {
                        MenuItems = MenuItems.Where(mitem => !(mitem is PopperPlatter) && !(mitem is PiperPlatter));
                    }
                    else if (MenuTypes.Contains("Platters"))
                    {
                        MenuItems = MenuItems.Where(mitem => !(mitem is Popper));
                    }                    
                }else if(!(MenuTypes.Contains("Treats")) && MenuTypes.Length == 1)
                {
                    if (MenuTypes.Contains("Poppers"))
                    {
                        MenuItems = MenuItems.Where(mitem => mitem is Popper);
                    }
                    else if (MenuTypes.Contains("Platters"))
                    {
                        MenuItems = MenuItems.Where(mitem => mitem is PopperPlatter || mitem is PiperPlatter);
                    }
                }else if(!(MenuTypes.Contains("Treats")) && MenuTypes.Length == 2)
                {
                    MenuItems = MenuItems.Where(mitem => mitem is PopperPlatter || mitem is PiperPlatter || mitem is Popper);
                }
            }

            TreatItems = MenuItems.Where(mitem => !(mitem is Popper) && !(mitem is PopperPlatter) && !(mitem is PiperPlatter));
            PopperItems = MenuItems.Where(mitem => mitem is Popper);
            PlatterItems = MenuItems.Where(mitem => mitem is PopperPlatter || mitem is PiperPlatter);
        }
    }
}
