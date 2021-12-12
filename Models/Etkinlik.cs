using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class Etkinlik
    {
        public int Id { get; set; }

        public string EtkinlikBaslik { get; set; } = "";
        public string EtkinlikAciklama { get; set; } = "";

        public DateTime EtkinlikTarih { get; set; } = DateTime.Now;
    }
}
