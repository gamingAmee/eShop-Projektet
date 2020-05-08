using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Datalayer.Entities;

namespace ServiceLayer.ProduktService
{
    public static class ProduktDtoSelect
    {
        public static IQueryable<ProduktDto> MapProduktToDto(this IQueryable<Produkt> produkter)
        {
            return produkter.Select(b => new ProduktDto
            {
                ProduktId = b.ProduktId,
                Navn = b.Navn,
                Pris = b.Pris,

                Billede = b.ProduktBilleder,
                Kategori = b.Kategori.Navn,
                Producent = b.Producent.Navn
            });
        }
    }
}
