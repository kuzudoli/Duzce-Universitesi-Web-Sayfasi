using DuzceUniTez.Data;
using DuzceUniTez.Data.Repository;
using DuzceUniTez.Models;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class HomeController : Controller
    {
        //DbContext tanımlanıyor
        private IRepository _repo;

        public HomeController(IRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            DataCollectionViewModel mymodel = new DataCollectionViewModel();
            mymodel.Duyurular = _repo.GetAllDuyurular();
            mymodel.Etkinlikler = _repo.GetAllEtkinlikler();
            mymodel.Haberler = _repo.GetAllHaberler().TakeLast(4).Reverse();
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Bolumler = _repo.GetAllBolumler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            ViewBag.fakulteSayisi = _repo.GetAllFakulteler().Count();
            ViewBag.bolumSayisi = _repo.GetAllBolumler().Where(b => b.BolumTipi == "Lisans").Count();
            ViewBag.lisansustuBolumSayisi = _repo.GetAllBolumler().Where(b => b.BolumTipi == "Lisansüstü").Count();

            ViewBag.enstituSayisi = _repo.GetAllEnstituler().Count();
            ViewBag.yuksekOkulSayisi = _repo.GetAllYuksekOkullar().Count();
            ViewBag.meslekYuksekOkulSayisi = _repo.GetAllMeslekYuksekOkullar().Count();

            return View(mymodel);
        }

    }
}
