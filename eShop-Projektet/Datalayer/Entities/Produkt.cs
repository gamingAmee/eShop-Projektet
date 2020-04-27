using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopProjektet.Entities
{
    public class Produkt
    {
        public int Produkt_Id { get; set; }
        public string Navn { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public byte Image { get; set; }

        public ICollection<OrdreProdukt> Produkts { get; set; }
    }
}
