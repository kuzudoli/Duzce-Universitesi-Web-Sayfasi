using DuzceUniTez.Data.FileManager;
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
    public class FakulteController : MenuController
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public FakulteController(IRepository repo, IFileManager fileManager) : base(repo)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index(int id)
        {
            DataViewModel mymodel = new DataViewModel();
            //menu
            mymodel = GetMenu(mymodel);

            //Fakulte fakulte = _repo.GetFakulte(id);
            mymodel.Bolumler = _repo.GetAllBolumler().Where(b => b.FakulteId == id);
            mymodel.Fakulte = _repo.GetFakulte(id);

            return View(mymodel);
        }
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.')+1);
            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mime}");
        }
    }
}
