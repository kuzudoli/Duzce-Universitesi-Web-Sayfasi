﻿using DuzceUniTez.Data.Repository;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class YuksekOkulController : Controller
    {
        private IRepository _repo;

        public YuksekOkulController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel.Duyurular = _repo.GetAllDuyurular();
            mymodel.Etkinlikler = _repo.GetAllEtkinlikler();
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.YuksekOkul = _repo.GetYuksekOkul(id);

            return View(mymodel);
        }
    }
}
