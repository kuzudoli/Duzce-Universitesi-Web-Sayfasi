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
    public class MeslekYuksekOkulController : MenuController
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public MeslekYuksekOkulController(IRepository repo, IFileManager fileManager):base(repo)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.MeslekYuksekOkul = _repo.GetMeslekYuksekOkul(id);

            return View(mymodel);
        }

    }
}
