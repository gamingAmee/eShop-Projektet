using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Datalayer.Entities
{
    public class Kunde
    {
        public int KundeId { get; set; }
        [Required, StringLength(50)]
        public string Fornavn { get; set; }
        [Required, StringLength(50)]
        public string Efternavn { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
        [Required, StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        public string Kodeord { get; set; }
        [Required, StringLength(50)]
        public string Adresse { get; set; }

        public ICollection<Ordre> Ordrer { get; set; } //Ref
    }
}
