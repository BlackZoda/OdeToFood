using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class EditModel : PageModel
    {
        private readonly IResturantData resturantData;
        [BindProperty]
        public Resturant Resturant { get; set; }
        public IEnumerable<SelectListItem> Cousines { get; set; }
        private readonly IHtmlHelper htmlHelper;
        public EditModel(IResturantData resturantData, IHtmlHelper htmlHelper)
        {
            this.htmlHelper = htmlHelper;
            this.resturantData = resturantData;
        }
        public IActionResult OnGet(int? resturantId)
        {
            Cousines = htmlHelper.GetEnumSelectList<CousineType>();
            if (resturantId.HasValue)
                Resturant = resturantData.GetById(resturantId.Value);
            else
            {
                Resturant = new Resturant();
            }
            if (Resturant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cousines = htmlHelper.GetEnumSelectList<CousineType>();
                return Page();
            }

            if (Resturant.Id > 0)
            {
                resturantData.Update(Resturant);
            }
            else
            {
                resturantData.Add(Resturant);
            }
            resturantData.Commit();
            TempData["Message"] = "Resturant saved!";
            return RedirectToPage("./Detail", new { resturantId = Resturant.Id });
        }
    }
}