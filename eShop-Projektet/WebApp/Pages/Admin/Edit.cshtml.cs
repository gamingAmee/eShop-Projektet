using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
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

        ILogger<EditModel> logger;

        public EditModel(IProduktService produktService, ILogger<EditModel> logger)
        {
            _produktService = produktService;
            this.logger = logger;
        }

        public async Task<IActionResult> OnGetAsync(int? produktid)
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
                Produkt = await _produktService.GetProduktById(produktid.Value);
            }

            if (Produkt == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
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

            try
            {
               await _produktService.Update(Produkt);
                logger.LogDebug("Produkt er blevet updatetet");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error");
                return Page();
            }
            Log.CloseAndFlush();

            return RedirectToPage("./AdminIndex");
        }
    }
}
