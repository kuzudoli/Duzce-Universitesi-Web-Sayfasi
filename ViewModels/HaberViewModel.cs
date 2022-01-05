using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class HaberViewModel
    {
        public int Id { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAciklama { get; set; }
        public string HaberKategori { get; set; }

        public IFormFile HaberResim { get; set; } = null;
        public string yukluHaberResim { get; set; } = null;

        public DateTime HaberTarih { get; set; } = DateTime.Now;
    }
}
