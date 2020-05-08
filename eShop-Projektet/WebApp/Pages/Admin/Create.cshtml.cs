using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Admin
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProduktDto Produkt { get; set; }
        public IEnumerable<SelectListItem> Kategorier { get; set; }
        public IEnumerable<SelectListItem> Producenter { get; set; }

        private readonly IProduktService _produktService;
        public CreateModel(IProduktService produktService)
        {
            _produktService = produktService;

        }

        public IActionResult OnGet()
        {
            Kategorier = _produktService.GetKategorier().Select(
                    kategorinavn => new SelectListItem
                    {
                        Value = kategorinavn.kategoriId.ToString(),
                        Text = kategorinavn.Navn
                    }).ToList();



            Producenter = _produktService.GetProducenter().Select(
                producentnavn => new SelectListItem
                {
                    Value = producentnavn.ProducentId.ToString(),
                    Text = producentnavn.Navn
                }).ToList();
            return Page();
        }


        public IActionResult OnPost()
        {
            Kategorier = _produktService.GetKategorier().Select(
                kategorinavn => new SelectListItem
                {
                    Value = kategorinavn.kategoriId.ToString(),
                    Text = kategorinavn.Navn
                }).ToList();

            Producenter = _produktService.GetProducenter().Select(
                producentnavn => new SelectListItem
                {
                    Value = producentnavn.ProducentId.ToString(),
                    Text = producentnavn.Navn
                }).ToList();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _produktService.Create(Produkt);

            return RedirectToPage("./AdminIndex");
        }
    }
}
