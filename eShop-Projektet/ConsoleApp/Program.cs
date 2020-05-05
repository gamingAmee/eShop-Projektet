using System;
using Microsoft.EntityFrameworkCore;
using Datalayer;
using Datalayer.Entities;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EshopContext())
            {
                var ProduktService = new ListProduktService(context);
                var produkter = ProduktService.SortFilterPage(new SortFilterPageOptions
                {
                    OrderByOptions = OrderByOptions.ByNameAsc,
                    FilterBy = ProdukterFilterBy.ByNavn,
                    FilterValue = "Asus",

                    PageNum = 1,
                    PageSize = 2
                }).ToList();

                foreach (ProduktListDto produkt in produkter)
                {
                    Console.WriteLine("\nProdukt navn: {0} \nPris: {1}",
                        produkt.Navn,
                        produkt.Pris
                        );
                }
            }
        }
    }
}
