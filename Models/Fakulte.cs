using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class Fakulte
    {
        public int Id { get; set; }
        public string FakulteAd { get; set; } = "";
        public string FakulteAciklama { get; set; } = "";

        public string FakulteResim { get; set; } = "";

        public string FakulteAdres { get; set; }
        public string FakulteTel { get; set; }
        public string FakulteMail { get; set; }



        public virtual List<Bolum> Bolumler { get; set; }

    }
}
