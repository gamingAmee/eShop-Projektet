using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Datalayer;
using Datalayer.QueryObjects;
using Datalayer.Entities;
using System.Threading.Tasks;

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

        public async Task<ProduktDto> GetProduktById(int produktId)
        {
            Produkt produkt = await _context.Produkter.AsNoTracking().Include(p => p.ProduktBilleder).SingleOrDefaultAsync(p => p.ProduktId == produktId);
            return new ProduktDto { ProduktId = produkt.ProduktId, Navn = produkt.Navn, Pris = produkt.Pris, Billede = produkt.ProduktBilleder };
        }

        public async Task<ProduktDto> Create(ProduktDto newProdukt)
        {
            Produkt produkt = new Produkt { Navn = newProdukt.Navn, Pris = newProdukt.Pris, KategoriId = newProdukt.KategoriId, ProducentId = newProdukt.ProducentId };
             _context.Produkter.Add(produkt);
           await _context.SaveChangesAsync();
            return newProdukt;
        }

        public async Task<ProduktDto> Update(ProduktDto updatedProdukt)
        { 
            Produkt produkt = new Produkt { ProduktId = updatedProdukt.ProduktId ,Navn = updatedProdukt.Navn, Pris = updatedProdukt.Pris, KategoriId = updatedProdukt.KategoriId, ProducentId = updatedProdukt.ProducentId} ;
             _context.Produkter.Update(produkt);

            await _context.SaveChangesAsync();
            return updatedProdukt;
        }

        public async Task<ProduktDto> Delete(int produktId)
        {
            Produkt produkt = await _context.Produkter.Include(p => p.ProduktBilleder).Include(p => p.Producent).Include(p => p.Kategori).SingleOrDefaultAsync(p => p.ProduktId == produktId);
            if (produkt != null)
            {
                _context.Produkter.Remove(produkt);
            }
            await _context.SaveChangesAsync();
            return new ProduktDto { ProduktId = produkt.ProduktId, Navn = produkt.Navn, Pris = produkt.Pris, Billede = produkt.ProduktBilleder };
        }
    }
}
