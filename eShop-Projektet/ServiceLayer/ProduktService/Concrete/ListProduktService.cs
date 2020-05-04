using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Datalayer;
using Datalayer.QueryObjects;

namespace ServiceLayer.ProduktService.Concrete
{
    public class ListProduktService
    {
        private readonly EshopContext _context;

        public ListProduktService(EshopContext context)
        {
            _context = context;
        }

        public IQueryable<ProduktListDto> AddProdukt()
        {
            var blogsQuery = _context.Produkter
                .AsNoTracking()
                .MapProduktToDto();
            return blogsQuery;
        }

        public IQueryable<ProduktListDto> SortFilterPage(SortFilterPageOptions options)
        {
            var ProdukterQuery = _context.Produkter
                .AsNoTracking()
                .MapProduktToDto()
                .OrderProduktsBy(options.OrderByOptions)
                .FilterBlogsBy(options.FilterBy, options.FilterValue);

            options.SetupRestOfDto(ProdukterQuery);                             // Added
            return ProdukterQuery.Page(options.PageNum - 1, options.PageSize);
        }
    }
}
