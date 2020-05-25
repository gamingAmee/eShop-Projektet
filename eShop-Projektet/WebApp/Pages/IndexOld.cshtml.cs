using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<ProduktDto> Produkts { get; set; }

        private readonly IProduktService _produktService;

        public IndexModel(IProduktService produktService)
        {
            _produktService = produktService;
        }

        public void OnGet()
        {
            Produkts = _produktService.GetProdukts();
        }
    }
}
