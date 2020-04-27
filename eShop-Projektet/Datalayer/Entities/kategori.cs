using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class kategori
    {
        public int kategori_Id { get; set; }
        public string Navn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }
    }
}
