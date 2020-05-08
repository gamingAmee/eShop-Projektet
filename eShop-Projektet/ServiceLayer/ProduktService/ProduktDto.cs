using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Datalayer.Entities;

namespace ServiceLayer.ProduktService
{
    public class ProduktDto
    {
        public int ProduktId { get; set; }
        public string Navn { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Pris { get; set; }

        public ICollection<ProduktBillede> Billede { get; set; }

        public string Kategori { get; set; }
        public string Producent { get; set; }
    }
}
