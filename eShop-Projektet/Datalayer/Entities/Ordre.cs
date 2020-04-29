using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class Ordre
    {
        public int OrdreId { get; set; }
        public int KundeId { get; set; } //FK
        public DateTime KoebsDato { get; set; }

        public Kunde Kunde { get; set; } //Ref
        public ICollection<OrdreProdukt> Produkter { get; set; } //Ref
    }
}
