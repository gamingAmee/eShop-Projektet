using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.OrderService;
using Microsoft.AspNetCore.Http;
using WebApp.Extension;

namespace WebApp.ViewComponents
{
    public class VareKurvViewComponent : ViewComponent
    {
        private readonly IProduktService _produktService;
        public OrderDto Order { get; set; }

        public VareKurvViewComponent(IProduktService produktService)
        {
            _produktService = produktService;
        }

        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.Get("order") != null)
            {
                Order = HttpContext.Session.Get<OrderDto>("order");
                return View(Order.Produkts.Count());
            }
            return View(0);
        }
    }
}
