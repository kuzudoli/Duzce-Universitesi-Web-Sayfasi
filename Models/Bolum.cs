using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Models
{
    public class Bolum
    {
        public int Id { get; set; } //Fakülte tablosuna id olarak gidecek.
        public string BolumAdi { get; set; }
        public string BolumTipi { get; set; }
        public string Fakultesi { get; set; }


        public int FakulteId { get; set; }
        public virtual Fakulte Fakulte { get; set; }

    }
}
