using DuzceUniTez.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class DataViewModel:DataCollectionViewModel
    {
        public Fakulte Fakulte { get; set; }
        public Enstitu Enstitu { get; set; }
        public YuksekOkul YuksekOkul { get; set; }
        public MeslekYuksekOkul MeslekYuksekOkul { get; set; }
        public Haber Haber { get; set; }
        public Duyuru Duyuru { get; set; }
        public Etkinlik Etkinlik { get; set; }
    }
}
