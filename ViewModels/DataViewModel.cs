using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class DataViewModel:DataCollectionViewModel
    {
        public Fakulte Fakulte { get; set; }
        public Haber Haber { get; set; }
        public Duyuru Duyuru { get; set; }
        public Etkinlik Etkinlik { get; set; }
        //public IEnumerable<Bolum> Bolumler { get; set; }
    }
}
