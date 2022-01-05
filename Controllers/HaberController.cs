using DuzceUniTez.Data.FileManager;
using DuzceUniTez.Data.Repository;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class HaberController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public HaberController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.Haberler = _repo.GetAllHaberler();
            return View(mymodel);
        }

        public IActionResult Haber(int id)
        {
            DataViewModel mymodel = new DataViewModel();

            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            mymodel.Haber = _repo.GetHaber(id);
            return View(mymodel);
        }
    }
}
