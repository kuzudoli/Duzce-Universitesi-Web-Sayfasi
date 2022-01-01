using DuzceUniTez.Data.Repository;
using DuzceUniTez.Models;
using DuzceUniTez.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;

        public PanelController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Duyuru CRUD
        public IActionResult Duyurular()
        {
            var duyurular = _repo.GetAllDuyurular();
            return View(duyurular);
        }

        [HttpGet]
        //parametre verilmemişse yeni duyuru nesnesi oluşturuyor
        //parametre verildiyse parametreye ait bilgileri inputlara yükleyerek güncellemeye izin veriyor
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View(new Duyuru());
            else
            {
                var duyuru = _repo.GetDuyuru((int)id);
                return View(duyuru);
            }
        }

        [HttpPost]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> Edit(Duyuru duyuru)
        {
            if (duyuru.Id == 0)
                _repo.AddDuyuru(duyuru);
            else
                _repo.UpdateDuyuru(duyuru);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Duyurular");
            else
                return View(duyuru);
        }

        [HttpGet]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemoveDuyuru(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Duyurular");
        }
        #endregion Duyurular

        #region Etkinlik CRUD
        public IActionResult Etkinlikler()
        {
            var etkinlikler = _repo.GetAllEtkinlikler();
            return View(etkinlikler);
        }

        [HttpGet]
        //parametre verilmemişse yeni etkinlik nesnesi oluşturuyor
        //parametre verildiyse parametreye ait bilgileri inputlara yükleyerek güncellemeye izin veriyor
        public IActionResult EditEtkinlik(int? id)
        {
            if (id == null)
                return View(new Etkinlik());
            else
            {
                var etkinlik = _repo.GetEtkinlik((int)id);
                return View(etkinlik);
            }
        }

        [HttpPost]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> EditEtkinlik(Etkinlik etkinlik)
        {
            if (etkinlik.Id == 0)
                _repo.AddEtkinlik(etkinlik);
            else
                _repo.UpdateEtkinlik(etkinlik);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Etkinlikler");
            else
                return View(etkinlik);
        }

        [HttpGet]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> RemoveEtkinlik(int id)
        {
            _repo.RemoveEtkinlik(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Etkinlikler");
        }
        #endregion

        #region Fakülte CRUD
        public IActionResult Fakulteler()
        {
            var fakulteler = _repo.GetAllFakulteler();
            return View(fakulteler);
        }

        [HttpGet]
        public IActionResult EditFakulteler(int? id)
        {
            if (id == null)
                return View(new Fakulte());
            else
            {
                var fakulte = _repo.GetFakulte((int)id);
                return View(fakulte);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditFakulteler(Fakulte fakulte)
        {
            if (fakulte.Id == 0)
                _repo.AddFakulte(fakulte);
            else
                _repo.UpdateFakulte(fakulte);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Fakulteler");
            else
                return View(fakulte);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveFakulte(int id)
        {
            _repo.RemoveFakulte(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Fakulteler");
        }
        #endregion

        #region Bölüm CRUD

        public IActionResult Bolumler()
        {
            var bolumler = _repo.GetAllBolumler();
            return View(bolumler);
        }

        [HttpGet]
        public IActionResult EditBolumler(int? id)
        {
            List<Fakulte> fakulteler = _repo.GetAllFakulteler(); //Fakülteler listesi doldurulur.
            ViewBag.Funds = fakulteler;

            if (id == null)
            {
                return View(new Bolum());
            }
            else
            {
                var bolum = _repo.GetBolum((int)id);
                return View(bolum);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditBolumler(Bolum bolum)
        {
            if (bolum.Id == 0)
                _repo.AddBolum(bolum);
            else
                _repo.UpdateBolum(bolum);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Bolumler");
            else
                return View(bolum);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveBolum(int id)
        {
            _repo.RemoveBolum(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Bolumler");
        }

        #endregion


        #region Enstitü CRUD

        public IActionResult Enstituler()
        {
            var enstituler = _repo.GetAllEnstituler();
            return View(enstituler);
        }

        [HttpGet]
        public IActionResult EditEnstituler(int? id)
        {
            if (id == null)
            {
                return View(new Enstitu());
            }
            else
            {
                var enstitu = _repo.GetEnstitu((int)id);
                return View(enstitu);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditEnstituler(Enstitu enstitu)
        {
            if (enstitu.Id == 0)
                _repo.AddEnstitu(enstitu);
            else
                _repo.UpdateEnstitu(enstitu);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Enstituler");
            else
                return View(enstitu);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveEnstitu(int id)
        {
            _repo.RemoveEnstitu(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Enstituler");
        }

        #endregion
    }
}
