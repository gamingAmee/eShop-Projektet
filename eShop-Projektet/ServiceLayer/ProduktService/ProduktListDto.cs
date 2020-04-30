using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceLayer.ProduktService
{
    public class ProduktListDto
    {
        public int ProduktId { get; set; }
        public string Navn { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Pris { get; set; }

        //public string Billede { get; set; }

        //public string Kategori { get; set; }
        //public string Producent { get; set; }
    }
}
