using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.ViewComponents
{
    public class VareKurvViewComponent : ViewComponent
    {
        private readonly IProduktService _produktService;


        public VareKurvViewComponent(IProduktService produktService)
        {
            _produktService = produktService;

        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
