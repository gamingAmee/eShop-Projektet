using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Datalayer.Entities;

namespace ServiceLayer.ProduktService
{
    public static class ProduktListDtoSelect
    {
        public static IQueryable<ProduktListDto> MapProduktToDto(this IQueryable<Produkt> produkter)
        {
            return produkter.Select(b => new ProduktListDto
            {
                ProduktId = b.ProduktId,
                Navn = b.Navn,
                Pris = b.Pris,

                Billede = b.ProduktBilleder.FirstOrDefault().Billede,
                //Kategori = b.Kategori.Navn,
                //Producent = b.Producent.Navn
            });
        }
    }
}
