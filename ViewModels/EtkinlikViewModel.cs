using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class EtkinlikViewModel
    {
        public int Id { get; set; }

        public string EtkinlikBaslik { get; set; } = "";
        public string EtkinlikAciklama { get; set; } = "";

        public IFormFile EtkinlikResim { get; set; } = null;
        public string yukluEtkinlikResim { get; set; } = null;

        public DateTime EtkinlikTarih { get; set; } = DateTime.Now;
    }
}
