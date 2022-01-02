﻿using DuzceUniTez.Data.Repository;
using DuzceUniTez.Models;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class FakulteController : Controller
    {
        private IRepository _repo;

        public FakulteController(IRepository repo)
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

            //Fakulte fakulte = _repo.GetFakulte(id);
            mymodel.Bolumler = _repo.GetAllBolumler().Where(b => b.FakulteId == id);
            mymodel.Fakulte = _repo.GetFakulte(id);

            return View(mymodel);
        }
    }
}