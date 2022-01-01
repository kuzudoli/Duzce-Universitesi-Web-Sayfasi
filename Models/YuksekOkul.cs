using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class YuksekOkul
    {
        public int Id { get; set; }
        public string YuksekOkulAd { get; set; } = "";
        public string YuksekOkulAciklama { get; set; } = "";

        //YuksekOkul Resmi Eklenecek.

        public string YuksekOkulAdres { get; set; }
        public string YuksekOkulTel { get; set; }
        public string YuksekOkulMail { get; set; }

    }
}
