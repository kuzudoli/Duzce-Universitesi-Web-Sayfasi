﻿using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.ViewModels
{
    public class DataCollectionViewModel
    {
        public IEnumerable<Duyuru> Duyurular { get; set; }
        public IEnumerable<Etkinlik> Etkinlikler { get; set; }
        public IEnumerable<Fakulte> Fakulteler { get; set; }
        public IEnumerable<Bolum> Bolumler { get; set; }
    }
}
