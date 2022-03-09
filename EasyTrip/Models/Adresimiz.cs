using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTrip.Models
{
    public class Adresimiz
    {
        [Key]
        public int AdresID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AcikAdres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}