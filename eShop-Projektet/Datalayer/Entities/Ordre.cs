using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class Ordre
    {
        public int OrdreId { get; set; }
        public int KundeId { get; set; }
        public DateTime KoebsDato { get; set; }

        public Kunde Kunde { get; set; }
        public ICollection<OrdreProdukt> Produkter { get; set; }
    }
}
