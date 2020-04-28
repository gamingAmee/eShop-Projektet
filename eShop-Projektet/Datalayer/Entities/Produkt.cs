using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Datalayer.Entities
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string Navn { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Pris { get; set; }
        
        public int KategoriId { get; set; }
        public kategori Kategori { get; set; }

        public ICollection<ProduktBillede> ProduktBilleder { get; set; }
        public ICollection<OrdreProdukt> Ordrer { get; set; }
    }
}
