﻿using DuzceUniTez.Data.Repository;
using DuzceUniTez.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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


        /*ETKİNLİK*/

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
    }
}