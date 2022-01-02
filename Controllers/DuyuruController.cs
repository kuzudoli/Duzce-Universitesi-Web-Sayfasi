using DuzceUniTez.Data.Repository;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class DuyuruController : Controller
    {
        private IRepository _repo;

        public DuyuruController(IRepository repo)
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

            mymodel.Duyurular = _repo.GetAllDuyurular();
            return View(mymodel);
        }

        public IActionResult Duyuru(int id)
        {
            DataViewModel mymodel = new DataViewModel();

            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.Duyuru = _repo.GetDuyuru(id);
            return View(mymodel);
        }
    }
}
