using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Datalayer.Entities
{
    public class Produkt
    {
        public int Produkt_Id { get; set; }
        public string Navn { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        
        public int Kategori_Id { get; set; }
        public kategori Kategori { get; set; }

        public ICollection<ProduktImage> ProduktImages { get; set; }
        public ICollection<OrdreProdukt> Ordrer { get; set; }
    }
}
