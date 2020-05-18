using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Admin
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public ProduktDto Produkt { get; set; }

        private readonly IProduktService _produktService;

        ILogger<EditModel> logger;

        public DeleteModel(IProduktService produktService, ILogger<EditModel> logger)
        {
            _produktService = produktService;
            this.logger = logger; 
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
            try
            {
                _produktService.Delete(produktId);
                logger.LogDebug("Produkt er blevet updatetet");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Det virker ikke");
                return Page();
            }

            Log.CloseAndFlush();
            return RedirectToPage("./AdminIndex");
        }
    }
}
