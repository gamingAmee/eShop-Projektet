using Datalayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceLayer.ProduktService
{
    public enum OrderByOptions
    {
        [Display(Name = "Sort by Navn ↓...")]
        ByNameAsc = 0,
        [Display(Name = "Navn ↑")]
        ByNameDesc,
        [Display(Name = "Pris ↓")]
        ByPriceDesc,
        [Display(Name = "Pris ↑")]
        ByPriceAsc
    }
    public static class ProduktDtoSort
    {
        public static IQueryable<ProduktDto> OrderProduktsBy(this IQueryable<ProduktDto> produkt, OrderByOptions orderByOptions)
        {
            switch (orderByOptions)
            {
                case OrderByOptions.ByNameAsc:
                    return produkt.OrderBy(x => x.Navn);

                case OrderByOptions.ByNameDesc:
                    return produkt.OrderByDescending(x => x.Navn);

                case OrderByOptions.ByPriceDesc:
                    return produkt.OrderBy(x => x.Pris);

                case OrderByOptions.ByPriceAsc:
                    return produkt.OrderByDescending(x => x.Pris);

                default:
                    throw new ArgumentOutOfRangeException(nameof(orderByOptions), orderByOptions, null);
            }
        }
    }
}
