using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datalayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.OrderService;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using WebApp.Extension;

namespace WebApp.Pages.Produkter
{
    public class DetailModel : PageModel
    {
        [BindProperty]
        public ProduktDto Produkt { get; set; }

        [BindProperty]
        public OrderDto Order { get; set; }

        private readonly IProduktService _produktService;

        public DetailModel(IProduktService produktService)
        {
            _produktService = produktService;
        }

        public IActionResult OnGet(int? produktId)
        {
            if (produktId != null)
            {
                Produkt = _produktService.GetProduktById(produktId.Value);
            }

            if (Produkt == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int produktId)
        {
            Produkt = _produktService.GetProduktById(produktId);

            if (HttpContext.Session.Get("order") != null)
            {
                Order = HttpContext.Session.Get<OrderDto>("order");
                ProduktDto p = new ProduktDto { ProduktId = Produkt.ProduktId, Navn = Produkt.Navn, Pris = Produkt.Pris };
                Order.Produkts.Add(p);

                HttpContext.Session.Set("order", Order);
            }
            else
            {
                ProduktDto p = new ProduktDto { ProduktId = Produkt.ProduktId, Navn = Produkt.Navn, Pris = Produkt.Pris };
                Order.Produkts.Add(p);

                HttpContext.Session.Set("order", Order);
            }
            if (Produkt == null)
            {
                return NotFound();
            }
            return Page();

        }
    }

}
