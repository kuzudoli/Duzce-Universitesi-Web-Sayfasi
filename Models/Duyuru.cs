using System;

namespace DuzceUniTez.Models
{
    public class Duyuru
    {
        public int Id { get; set; }

        public string DuyuruBaslik { get; set; } = "";
        public string DuyuruAciklama { get; set; } = "";

        public string DuyuruResim { get; set; } = "";

        public DateTime DuyuruTarih { get; set; } = DateTime.Now;
    }
}
