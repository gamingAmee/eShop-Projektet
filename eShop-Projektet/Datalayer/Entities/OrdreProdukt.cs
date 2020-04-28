﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class OrdreProdukt
    {
        public int OrdreId { get; set; }

        public int ProduktId { get; set; }
        public int Styk { get; set; }

        public Ordre Ordre { get; set; }
        public Produkt Produkt { get; set; }
    }
}
