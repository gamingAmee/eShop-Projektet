using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Datalayer.Entities
{
   public class Producent
    {
        public int ProducentId { get; set; }
        [Required]
        public string Navn { get; set; }

        public ICollection<Produkt> Produkter { get; set; } //Ref
    }
}
