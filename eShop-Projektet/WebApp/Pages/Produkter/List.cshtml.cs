using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using ServiceLayer.OrderService;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using WebApp.Extension;

namespace WebApp.Pages.Produkter
{
    public class ListModel : PageModel
    {
        public IEnumerable<ProduktDto> Produkts { get; set; }

        public SortFilterPageOptions SortFilterPage { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public OrderByOptions OrderBy { get; set; }

        public IEnumerable<SelectListItem> OrderByList { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages { get; set; }

        private readonly IProduktService _produktService;
        private IHtmlHelper _htmlHelper;

        public ListModel(IProduktService produktService, IHtmlHelper htmlHelper)
        {
            _produktService = produktService;
            _htmlHelper = htmlHelper;
        }

        public void OnGet()
        {
            SortFilterPage = new SortFilterPageOptions { FilterBy = ProdukterFilterBy.ByNavn, FilterValue = SearchTerm, OrderByOptions = OrderBy, PageNum = CurrentPage, PageSize = PageSize };
            Produkts = _produktService.SortFilterPage(SortFilterPage);
            OrderByList = _htmlHelper.GetEnumSelectList<OrderByOptions>();
            TotalPages = SortFilterPage.NumPages;
        }
    }
}