using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;

namespace WebApp.Pages.Produkter
{
    public class ListModel : PageModel
    {
        public IEnumerable<ProduktListDto> Produkts { get; set; }


        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public OrderByOptions OrderBy { get; set; }

        public IEnumerable<SelectListItem> OrderByList { get; set; }

        private readonly IListProduktService _produktService;
        private IHtmlHelper _htmlHelper;

        public ListModel(IListProduktService produktService, IHtmlHelper htmlHelper)
        {
            _produktService = produktService;
            _htmlHelper = htmlHelper;
        }

        public void OnGet()
        {
            OrderByList = _htmlHelper.GetEnumSelectList<OrderByOptions>();
            Produkts = _produktService.SortFilterPage(new SortFilterPageOptions { FilterBy = ProdukterFilterBy.ByNavn, FilterValue = SearchTerm, OrderByOptions = OrderBy});
        }
    }
}