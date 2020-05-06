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
    public class ListModel : PageModel
    {
        public IEnumerable<ProduktListDto> Produkts { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        private readonly IListProduktService _produktService;

        public ListModel(IListProduktService produktService)
        {
            _produktService = produktService;
        }

        public void OnGet()
        {
            Produkts = _produktService.SortFilterPage(new SortFilterPageOptions { FilterBy = ProdukterFilterBy.ByNavn, FilterValue = SearchTerm });
        }
    }
}