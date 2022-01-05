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
    public class EtkinlikController : MenuController
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public EtkinlikController(IRepository repo, IFileManager fileManager):base(repo)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.Etkinlikler = _repo.GetAllEtkinlikler();

            return View(mymodel);
        }

        public IActionResult Etkinlik(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.Etkinlik = _repo.GetEtkinlik(id);

            return View(mymodel);
        }
    }
}
