using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceLayer.ProduktService
{
    public enum ProdukterFilterBy
    {
        [Display(Name = "All")]
        NoFilter = 0,
        [Display(Name = "By Navn...")]
        ByNavn,
        [Display(Name = "By Pris...")]
        ByPris
    }
    public static class ProduktDtoFilter
    {
        public static IQueryable<ProduktDto> FilterProduktsBy(this IQueryable<ProduktDto> produkter, ProdukterFilterBy filterBy, string filterValue)
        {
            if (string.IsNullOrEmpty(filterValue))
                return produkter;

            switch (filterBy)
            {
                case ProdukterFilterBy.NoFilter:
                    return produkter;

                case ProdukterFilterBy.ByNavn:
                    return produkter.Where(x => EF.Functions.Like(x.Navn, $"%{filterValue}%"));

                case ProdukterFilterBy.ByPris:
                    return produkter.Where(x => x.Pris <= int.Parse(filterValue));

                default:
                    throw new ArgumentOutOfRangeException(nameof(filterBy), filterBy, null);
            }
        }
    }
}

