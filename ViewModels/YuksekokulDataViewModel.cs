using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class YuksekokulDataViewModel
    {
        public int Id { get; set; }
        public string YuksekOkulAd { get; set; } = "";
        public string YuksekOkulAciklama { get; set; } = "";

        public IFormFile YuksekOkulResim { get; set; } = null;
        public string yukluYuksekOkulResim { get; set; } = null;

        public string YuksekOkulAdres { get; set; }
        public string YuksekOkulTel { get; set; }
        public string YuksekOkulMail { get; set; }
    }
}
