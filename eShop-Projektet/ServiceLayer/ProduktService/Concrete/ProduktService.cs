using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Datalayer;
using Datalayer.QueryObjects;
using Datalayer.Entities;

namespace ServiceLayer.ProduktService.Concrete
{
    public class ProduktService : IProduktService
    {
        private readonly EshopContext _context;

        public ProduktService(EshopContext context)
        {
            _context = context;
        }

        public IQueryable<ProduktDto> AddProdukt()
        {
            var ProdukterQuery = _context.Produkter
                .AsNoTracking()
                .MapProduktToDto();
            return ProdukterQuery;
        }

        public IQueryable<ProduktDto> GetProdukts()
        {
            var ProdukterQuery = _context.Produkter
                .AsNoTracking()
                .MapProduktToDto();
            return ProdukterQuery;
        }

        public IQueryable<kategori> GetKategorier()
        {
            
            return _context.kategorier;
        }

        public IQueryable<Producent> GetProducenter()
        {
            return _context.Producenter;
        }

        public IQueryable<ProduktDto> SortFilterPage(SortFilterPageOptions options)
        {
            var ProdukterQuery = _context.Produkter
                .AsNoTracking()
                .MapProduktToDto()
                .OrderProduktsBy(options.OrderByOptions)
                .FilterProduktsBy(options.FilterBy, options.FilterValue);

            options.SetupRestOfDto(ProdukterQuery);
            return ProdukterQuery.Page(options.PageNum - 1, options.PageSize);
        }

        public ProduktDto GetProduktById(int produktId)
        {
            Produkt produkt = _context.Produkter.Include(p => p.ProduktBilleder).SingleOrDefault(p => p.ProduktId == produktId);
            return new ProduktDto { ProduktId = produkt.ProduktId, Navn = produkt.Navn, Pris = produkt.Pris, Billede = produkt.ProduktBilleder };
        }

        public ProduktDto Update(ProduktDto updatedProdukt)
        { 
            Produkt produkt = new Produkt { ProduktId = updatedProdukt.ProduktId ,Navn = updatedProdukt.Navn, Pris = updatedProdukt.Pris, KategoriId = updatedProdukt.KategoriId, ProducentId = updatedProdukt.ProducentId} ;
            _context.Attach(produkt);
            _context.Entry(produkt).State = EntityState.Modified;

            _context.SaveChanges();
            return updatedProdukt;
        }
    }
}
