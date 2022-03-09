using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTrip.Models
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}