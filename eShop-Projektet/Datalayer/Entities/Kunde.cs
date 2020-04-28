using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class Kunde
    {
        public int KundeId { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Kodeord { get; set; }
        public string Adresse { get; set; }

        public ICollection<Ordre> Ordrer { get; set; }
    }
}
