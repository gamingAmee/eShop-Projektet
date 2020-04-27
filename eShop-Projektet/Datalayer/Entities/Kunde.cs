using System;
using System.Collections.Generic;
using System.Text;

namespace eShopProjektet.Entities
{
    public class Kunde
    {
        public int Kunde_Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public ICollection<Ordre> Ordres { get; set; }
    }
}
