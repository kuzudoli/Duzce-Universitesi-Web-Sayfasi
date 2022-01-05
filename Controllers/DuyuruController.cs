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
    public class DuyuruController : MenuController
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public DuyuruController(IRepository repo, IFileManager fileManager) : base(repo)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.Duyurular = _repo.GetAllDuyurular();

            return View(mymodel);
        }

        public IActionResult Duyuru(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.Duyuru = _repo.GetDuyuru(id);

            return View(mymodel);
        }

    }
}
