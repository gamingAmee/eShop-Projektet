using System;
using System.Collections.Generic;
using System.Text;

namespace eShopProjektet.Entities
{
    public class Ordre
    {
        public int Ordre_Id { get; set; }
        public int Kunde_Id { get; set; }
        public DateTime KoebsDato { get; set; }

        public ICollection<OrdreProdukt> Ordres { get; set; }
    }
}
