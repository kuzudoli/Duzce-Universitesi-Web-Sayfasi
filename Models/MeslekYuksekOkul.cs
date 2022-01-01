using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class MeslekYuksekOkul
    {
        public int Id { get; set; }
        public string MeslekYuksekOkulAd { get; set; } = "";
        public string MeslekYuksekOkulAciklama { get; set; } = "";

        //MeslekYuksekOkul Resmi Eklenecek.

        public string MeslekYuksekOkulAdres { get; set; }
        public string MeslekYuksekOkulTel { get; set; }
        public string MeslekYuksekOkulMail { get; set; }

    }
}
