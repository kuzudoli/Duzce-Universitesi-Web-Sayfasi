using DuzceUniTez.Data.Repository;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class EtkinlikController : Controller
    {
        private IRepository _repo;

        public EtkinlikController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.Etkinlikler = _repo.GetAllEtkinlikler();
            return View(mymodel);
        }

        public IActionResult Etkinlik(int id)
        {
            DataViewModel mymodel = new DataViewModel();

            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.Etkinlik = _repo.GetEtkinlik(id);
            return View(mymodel);
        }
    }
}
