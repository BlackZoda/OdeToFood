using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IResturantData resturantData;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public IEnumerable<Resturant> ResturantList { get; set; }
        public ListModel(IConfiguration config, IResturantData resturantData)
        {
            this.resturantData = resturantData;
            this.config = config;
        }
        public void OnGet(string searchTerm)
        {
            Message = config["Message"];
            ResturantList = resturantData.GetResturantsByName(SearchTerm);
        }
    }
}