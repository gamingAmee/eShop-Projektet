using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Admin
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ProduktDto Produkt { get; set; }

        public IEnumerable<SelectListItem> Kategorier { get; set; }
        public IEnumerable<SelectListItem> Producenter { get; set; }

        private readonly IProduktService _produktService;
        public EditModel(IProduktService produktService)
        {
            _produktService = produktService;

        }

        public IActionResult OnGet(int? produktid)
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

            if (produktid != null)
            {
                Produkt = _produktService.GetProduktById(produktid.Value);
            }

            if (Produkt == null)
            {
                return NotFound();
            }

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

            _produktService.Update(Produkt);

            return RedirectToPage("./AdminIndex");
        }
    }
}
