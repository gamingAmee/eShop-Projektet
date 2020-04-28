using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
   public class Producent
    {
        public int ProducentId { get; set; }
        public string Navn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }
    }
}
