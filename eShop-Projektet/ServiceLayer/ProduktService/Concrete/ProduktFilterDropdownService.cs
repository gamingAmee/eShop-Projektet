using System;
using System.Collections.Generic;
using System.Text;
using Datalayer;
using Datalayer.Entities;

namespace ServiceLayer.ProduktService.Concrete
{
   public class ProduktFilterDropdownService
    {
        private readonly EshopContext _context;

        public ProduktFilterDropdownService(EshopContext context)
        {
            _context = context;
        }
    }
}
