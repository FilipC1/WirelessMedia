using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WirelessMedia.Models
{
    [Table("Proizvod")]
    public partial class Proizvod
    {
        public int ProizvodId { get; set; }
        [StringLength(100)]
        public string Naziv { get; set; }
        [StringLength(100)]
        public string Opis { get; set; }
        [StringLength(100)]
        public string Kategorija { get; set; }
        [StringLength(100)]
        public string Proizvodjac { get; set; }
        [StringLength(100)]
        public string Dobavljac { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cena { get; set; }
    }
}
