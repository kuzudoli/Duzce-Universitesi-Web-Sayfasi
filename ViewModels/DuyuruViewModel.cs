using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class DuyuruViewModel
    {
        public int Id { get; set; }

        public string DuyuruBaslik { get; set; } = "";
        public string DuyuruAciklama { get; set; } = "";

        public IFormFile DuyuruResim { get; set; } = null;
        public string yukluDuyuruResim { get; set; } = null;

        public DateTime DuyuruTarih { get; set; } = DateTime.Now;
    }
}
