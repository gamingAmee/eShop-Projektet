using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Produkter
{
    public class DetailModel : PageModel
    {
        public ProduktDto Produkt { get; set; }

        private readonly IProduktService _produktService;
        

        public DetailModel(IProduktService produktService)
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
    }
}