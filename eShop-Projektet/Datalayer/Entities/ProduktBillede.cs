using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Datalayer.Entities
{
    public class ProduktBillede
    {
        public int ProduktBilledeId { get; set; }
        [Required]
        public string Billede { get; set; }

        public int ProduktId { get; set; } //FK
        public Produkt Produkt { get; set; } //Ref
    }
}
