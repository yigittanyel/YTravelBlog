using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTrip.Models
{
    public class Yorumlar
    {
        [Key]
        public int YorumlarID { get; set; }
        public string Kullanici { get; set; }
        public string Mail { get; set; } // burada amaç daha sonra bir duyuru vs. yapılacaksa kullanıcı verisi oluşturmak.
        public string Yorum { get; set; }

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }

    }
}