using DuzceUniTez.Data.Repository;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    public class MenuController : Controller
    {
        private IRepository _repo;

        public MenuController(IRepository repo)
        {
            _repo = repo;
        }

        public DataViewModel GetMenu(DataViewModel mymodel)
        {
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();
            return mymodel;
        }
    }
}
