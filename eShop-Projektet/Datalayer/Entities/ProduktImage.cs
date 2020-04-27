using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class ProduktImage
    {
        public int Image_id { get; set; }
        public byte Image { get; set; }

        public int Produkt_Id { get; set; }
        public Produkt Produkt { get; set; }
    }
}
