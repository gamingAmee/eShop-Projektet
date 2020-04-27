using System;
using System.Collections.Generic;
using System.Text;

namespace eShopProjektet.Entities
{
    public class OrdreProdukt
    {
        public int Ordre_Id { get; set; }

        public int Produkt_Id { get; set; }

        public Ordre Ordre { get; set; }
        public Produkt Produkt { get; set; }
    }
}
