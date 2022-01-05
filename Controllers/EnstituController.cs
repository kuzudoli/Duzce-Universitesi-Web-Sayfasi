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
    public class EnstituController : MenuController
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public EnstituController(IRepository repo, IFileManager fileManager):base(repo)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);
            mymodel.Enstitu = _repo.GetEnstitu(id);

            return View(mymodel);
        }
    }
}
