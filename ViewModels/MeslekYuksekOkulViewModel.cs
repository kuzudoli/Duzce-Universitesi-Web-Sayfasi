using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class MeslekYuksekOkulViewModel
    {
        public int Id { get; set; }
        public string MeslekYuksekOkulAd { get; set; } = "";
        public string MeslekYuksekOkulAciklama { get; set; } = "";

        public IFormFile MeslekYuksekOkulResim { get; set; } = null;
        public string yukluMeslekYuksekOkulResim { get; set; } = null;

        public string MeslekYuksekOkulAdres { get; set; }
        public string MeslekYuksekOkulTel { get; set; }
        public string MeslekYuksekOkulMail { get; set; }
    }
}
