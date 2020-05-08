using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Admin
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public ProduktDto Produkt { get; set; }

        private readonly IProduktService _produktService;
        public DeleteModel(IProduktService produktService)
        {
            _produktService = produktService;

        }

        public IActionResult OnGet(int produktId)
        {
            Produkt = _produktService.GetProduktById(produktId);
            if (Produkt == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int produktId)
        {
            var produkt = _produktService.Delete(produktId);

            if (produkt == null)
            {
                return RedirectToPage("./NotFound");
            }
            return RedirectToPage("./AdminIndex");
        }
    }
}
