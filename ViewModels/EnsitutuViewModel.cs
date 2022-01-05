using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class EnsitutuViewModel
    {
        public int Id { get; set; }
        public string EnsitutuAd { get; set; } = "";
        public string EnsitutuAciklama { get; set; } = "";

        public IFormFile EnsitutuResim { get; set; } = null;
        public string yukluEnsitutuResim { get; set; } = null;

        public string EnsitutuAdres { get; set; }
        public string EnsitutuTel { get; set; }
        public string EnsitutuMail { get; set; }
    }
}
