using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class ProduktBillede
    {
        public int ProduktBilledeId { get; set; }
        public byte Billede { get; set; }

        public int ProduktId { get; set; }
        public Produkt Produkt { get; set; }
    }
}
