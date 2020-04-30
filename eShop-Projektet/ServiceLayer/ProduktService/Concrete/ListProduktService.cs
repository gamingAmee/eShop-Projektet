using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Datalayer;

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
    }
}
