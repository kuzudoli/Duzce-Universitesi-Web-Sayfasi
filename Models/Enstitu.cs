using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class Enstitu
    {
        public int Id { get; set; }
        public string EnsitutuAd { get; set; } = "";
        public string EnsitutuAciklama { get; set; } = "";

        //Ensitutu Resmi Eklenecek.

        public string EnsitutuAdres { get; set; }
        public string EnsitutuTel { get; set; }
        public string EnsitutuMail { get; set; }

    }
}
