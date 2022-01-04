using DuzceUniTez.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class FakulteViewModel
    {
        public int Id { get; set; }
        public string FakulteAd { get; set; } = "";
        public string FakulteAciklama { get; set; } = "";

        public IFormFile FakulteResim { get; set; } = null;
        public string yukluFakulteResim { get; set; } = null;

        public string FakulteAdres { get; set; } = "";
        public string FakulteTel { get; set; } = "";
        public string FakulteMail { get; set; } = "";

        public virtual List<Bolum> Bolumler { get; set; }
    }
}
