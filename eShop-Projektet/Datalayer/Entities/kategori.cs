using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Datalayer.Entities
{
    public class kategori
    {
        public int kategoriId { get; set; }
        [Required]
        public string Navn { get; set; }

        public ICollection<Produkt> Produkts { get; set; } //Ref
    }
}
