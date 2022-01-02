using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAciklama { get; set; }
        public string HaberKategori { get; set; }
        public DateTime HaberTarih { get; set; } = DateTime.Now;
        //Haber resmi

    }
}
