using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class OrdreProdukt
    {
        public int OrdreId { get; set; } //PK/FK

        public int ProduktId { get; set; } //PK/FK
        public int Styk { get; set; }

        public Ordre Ordre { get; set; } //Ref
        public Produkt Produkt { get; set; } //Ref
    }
}
