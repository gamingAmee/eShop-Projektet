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
        
        public int KategoriId { get; set; } //FK
        public kategori Kategori { get; set; } //Ref

        public int ProducentId { get; set; } //FK
        public Producent Producent { get; set; } //Ref

        public ICollection<ProduktBillede> ProduktBilleder { get; set; } //Ref

        public ICollection<OrdreProdukt> Ordrer { get; set; } //Ref
    }
}
