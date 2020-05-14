using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.OrderService;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using WebApp.Extension;

namespace WebApp.Pages.Produkter
{
    public class VareKurvModel : PageModel
    {
        [BindProperty]
        public IEnumerable<ProduktDto> Produkts { get; set; }

        [BindProperty]
        public OrderDto Order { get; set; }

        private readonly IProduktService _produktService;

        public VareKurvModel(IProduktService produktService)
        {
            _produktService = produktService;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.Get("order") != null)
            {
                Order = HttpContext.Session.Get<OrderDto>("order");
                Produkts = Order.Produkts;
                
            }
            return Page();
        }
    }
}