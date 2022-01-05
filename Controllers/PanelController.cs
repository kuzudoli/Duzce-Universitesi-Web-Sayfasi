using DuzceUniTez.Data.FileManager;
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
        private IFileManager _fileManager;
        public PanelController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            DataCollectionViewModel mymodel = new DataCollectionViewModel();

            mymodel.Duyurular = _repo.GetAllDuyurular();
            mymodel.Etkinlikler = _repo.GetAllEtkinlikler();
            mymodel.Haberler = _repo.GetAllHaberler().TakeLast(4).Reverse();
            mymodel.Fakulteler = _repo.GetAllFakulteler();
            mymodel.Bolumler = _repo.GetAllBolumler();
            mymodel.Enstituler = _repo.GetAllEnstituler();
            mymodel.YuksekOkullar = _repo.GetAllYuksekOkullar();
            mymodel.MeslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();

            ViewBag.duyuruSayisi = _repo.GetAllDuyurular().Count();
            ViewBag.etkinlikSayisi = _repo.GetAllEtkinlikler().Count();
            ViewBag.haberSayisi = _repo.GetAllHaberler().Count();
            ViewBag.fakulteSayisi = _repo.GetAllFakulteler().Count();
            ViewBag.bolumSayisi = _repo.GetAllBolumler().Count();
            ViewBag.bolumSayisiLisans = _repo.GetAllBolumler().Where(b => b.BolumTipi == "Lisans").Count();
            ViewBag.lisansustuBolumSayisiLisansUstu = _repo.GetAllBolumler().Where(b => b.BolumTipi == "Lisansüstü").Count();
            ViewBag.enstituSayisi = _repo.GetAllEnstituler().Count();
            ViewBag.yuksekOkulSayisi = _repo.GetAllYuksekOkullar().Count();
            ViewBag.meslekYuksekOkulSayisi = _repo.GetAllMeslekYuksekOkullar().Count();

            return View(mymodel);
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
                return View(new DuyuruViewModel());
            else
            {
                var duyuru = _repo.GetDuyuru((int)id);
                return View(new DuyuruViewModel
                {
                    Id = duyuru.Id,
                    DuyuruBaslik = duyuru.DuyuruBaslik,
                    DuyuruAciklama = duyuru.DuyuruAciklama,
                    DuyuruTarih = duyuru.DuyuruTarih,
                    yukluDuyuruResim = duyuru.DuyuruResim
                });
            }
        }

        [HttpPost]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> Edit(DuyuruViewModel vm)
        {
            Duyuru duyuru = new Duyuru()
            {
                Id = vm.Id,
                DuyuruBaslik = vm.DuyuruBaslik,
                DuyuruAciklama = vm.DuyuruAciklama,
                DuyuruTarih = vm.DuyuruTarih
            };

            if (vm.DuyuruResim == null)
                duyuru.DuyuruResim = vm.yukluDuyuruResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluDuyuruResim))
                    _fileManager.RemoveImage(vm.yukluDuyuruResim);

                duyuru.DuyuruResim = await _fileManager.SaveImage(vm.DuyuruResim);
            }

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
                return View(new EtkinlikViewModel());
            else
            {
                var etkinlik = _repo.GetEtkinlik((int)id);
                return View(new EtkinlikViewModel
                {
                    Id = etkinlik.Id,
                    EtkinlikBaslik = etkinlik.EtkinlikBaslik,
                    EtkinlikAciklama = etkinlik.EtkinlikAciklama,
                    EtkinlikTarih = etkinlik.EtkinlikTarih,
                    yukluEtkinlikResim = etkinlik.EtkinlikResim
                });
            }
        }

        [HttpPost]
        //Asenkron görev olarak tanımlanıyor
        public async Task<IActionResult> EditEtkinlik(EtkinlikViewModel vm)
        {
            Etkinlik etkinlik = new Etkinlik
            {
                Id = vm.Id,
                EtkinlikBaslik = vm.EtkinlikBaslik,
                EtkinlikAciklama = vm.EtkinlikAciklama,
                EtkinlikTarih = vm.EtkinlikTarih,
            };

            if (vm.EtkinlikResim == null)
                etkinlik.EtkinlikResim = vm.yukluEtkinlikResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluEtkinlikResim))
                    _fileManager.RemoveImage(vm.yukluEtkinlikResim);

                etkinlik.EtkinlikResim = await _fileManager.SaveImage(vm.EtkinlikResim);
            }

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
                return View(new FakulteViewModel());
            else
            {
                var fakulte = _repo.GetFakulte((int)id);
                return View(new FakulteViewModel
                {
                    Id = fakulte.Id,
                    FakulteAd = fakulte.FakulteAd,
                    FakulteAciklama = fakulte.FakulteAciklama,
                    FakulteAdres = fakulte.FakulteAdres,
                    FakulteMail = fakulte.FakulteMail,
                    FakulteTel = fakulte.FakulteTel,
                    Bolumler = fakulte.Bolumler,
                    yukluFakulteResim = fakulte.FakulteResim
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditFakulteler(FakulteViewModel vm)
        {
            Fakulte fakulte = new Fakulte()
            {
                Id = vm.Id,
                FakulteAd = vm.FakulteAd,
                FakulteAciklama = vm.FakulteAciklama,
                FakulteAdres = vm.FakulteAdres,
                FakulteMail = vm.FakulteMail,
                FakulteTel = vm.FakulteTel,
                Bolumler = vm.Bolumler
            };


            if (vm.FakulteResim == null)
                fakulte.FakulteResim = vm.yukluFakulteResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluFakulteResim))
                    _fileManager.RemoveImage(vm.yukluFakulteResim);

                fakulte.FakulteResim = await _fileManager.SaveImage(vm.FakulteResim);
            }


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
                return View(new EnsitutuViewModel());
            }
            else
            {
                var enstitu = _repo.GetEnstitu((int)id);
                return View(new EnsitutuViewModel
                {
                    Id = enstitu.Id,
                    EnsitutuAd = enstitu.EnsitutuAd,
                    EnsitutuAciklama = enstitu.EnsitutuAciklama,
                    EnsitutuAdres = enstitu.EnsitutuAdres,
                    EnsitutuTel = enstitu.EnsitutuTel,
                    EnsitutuMail = enstitu.EnsitutuMail,
                    yukluEnsitutuResim = enstitu.EnsitutuResim
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditEnstituler(EnsitutuViewModel vm)
        {
            Enstitu enstitu = new Enstitu
            {
                Id = vm.Id,
                EnsitutuAd = vm.EnsitutuAd,
                EnsitutuAciklama = vm.EnsitutuAciklama,
                EnsitutuAdres = vm.EnsitutuAdres,
                EnsitutuTel = vm.EnsitutuTel,
                EnsitutuMail = vm.EnsitutuMail,
            };

            if (vm.EnsitutuResim == null)
                enstitu.EnsitutuResim = vm.yukluEnsitutuResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluEnsitutuResim))
                    _fileManager.RemoveImage(vm.yukluEnsitutuResim);

                enstitu.EnsitutuResim = await _fileManager.SaveImage(vm.EnsitutuResim);
            }

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

        #region YüksekOkul CRUD

        public IActionResult YuksekOkullar()
        {
            var yuksekOkullar = _repo.GetAllYuksekOkullar();
            return View(yuksekOkullar);
        }

        [HttpGet]
        public IActionResult EditYuksekOkullar(int? id)
        {
            if (id == null)
            {
                return View(new YuksekokulDataViewModel());
            }
            else
            {
                var yuksekOkul = _repo.GetYuksekOkul((int)id);
                return View(new YuksekokulDataViewModel
                {
                    Id = yuksekOkul.Id,
                    YuksekOkulAd = yuksekOkul.YuksekOkulAd,
                    YuksekOkulAciklama = yuksekOkul.YuksekOkulAciklama,
                    YuksekOkulAdres = yuksekOkul.YuksekOkulAdres,
                    YuksekOkulTel = yuksekOkul.YuksekOkulTel,
                    YuksekOkulMail = yuksekOkul.YuksekOkulMail,
                    yukluYuksekOkulResim = yuksekOkul.YuksekOkulResim
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditYuksekOkullar(YuksekokulDataViewModel vm)
        {
            YuksekOkul yuksekOkul = new YuksekOkul
            {
                Id = vm.Id,
                YuksekOkulAd = vm.YuksekOkulAd,
                YuksekOkulAciklama = vm.YuksekOkulAciklama,
                YuksekOkulAdres = vm.YuksekOkulAdres,
                YuksekOkulTel = vm.YuksekOkulTel,
                YuksekOkulMail = vm.YuksekOkulMail,
            };

            if (vm.YuksekOkulResim == null)
                yuksekOkul.YuksekOkulResim = vm.yukluYuksekOkulResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluYuksekOkulResim))
                    _fileManager.RemoveImage(vm.yukluYuksekOkulResim);

                yuksekOkul.YuksekOkulResim = await _fileManager.SaveImage(vm.YuksekOkulResim);
            }

            if (yuksekOkul.Id == 0)
                _repo.AddYuksekOkul(yuksekOkul);
            else
                _repo.UpdateYuksekOkul(yuksekOkul);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("YuksekOkullar");
            else
                return View(yuksekOkul);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveYuksekOkul(int id)
        {
            _repo.RemoveYuksekOkul(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("YuksekOkullar");
        }

        #endregion

        #region Meslek YüksekOkul CRUD

        public IActionResult MeslekYuksekOkullar()
        {
            var meslekYuksekOkullar = _repo.GetAllMeslekYuksekOkullar();
            return View(meslekYuksekOkullar);
        }

        [HttpGet]
        public IActionResult EditMeslekYuksekOkullar(int? id)
        {
            if (id == null)
            {
                return View(new MeslekYuksekOkulViewModel());
            }
            else
            {
                var meslekYuksekOkul = _repo.GetMeslekYuksekOkul((int)id);
                return View(new MeslekYuksekOkulViewModel
                {
                    Id = meslekYuksekOkul.Id,
                    MeslekYuksekOkulAd = meslekYuksekOkul.MeslekYuksekOkulAd,
                    MeslekYuksekOkulAciklama = meslekYuksekOkul.MeslekYuksekOkulAciklama,
                    MeslekYuksekOkulAdres = meslekYuksekOkul.MeslekYuksekOkulAdres,
                    MeslekYuksekOkulTel = meslekYuksekOkul.MeslekYuksekOkulTel,
                    MeslekYuksekOkulMail = meslekYuksekOkul.MeslekYuksekOkulMail,
                    yukluMeslekYuksekOkulResim = meslekYuksekOkul.MeslekYuksekOkulResim
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditMeslekYuksekOkullar(MeslekYuksekOkulViewModel vm)
        {
            MeslekYuksekOkul meslekYuksekOkul = new MeslekYuksekOkul
            {
                Id = vm.Id,
                MeslekYuksekOkulAd = vm.MeslekYuksekOkulAd,
                MeslekYuksekOkulAciklama = vm.MeslekYuksekOkulAciklama,
                MeslekYuksekOkulAdres = vm.MeslekYuksekOkulAdres,
                MeslekYuksekOkulTel = vm.MeslekYuksekOkulTel,
                MeslekYuksekOkulMail = vm.MeslekYuksekOkulMail
            };

            if (vm.MeslekYuksekOkulResim == null)
                meslekYuksekOkul.MeslekYuksekOkulResim = vm.yukluMeslekYuksekOkulResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluMeslekYuksekOkulResim))
                    _fileManager.RemoveImage(vm.yukluMeslekYuksekOkulResim);

                meslekYuksekOkul.MeslekYuksekOkulResim = await _fileManager.SaveImage(vm.MeslekYuksekOkulResim);
            }

            if (meslekYuksekOkul.Id == 0)
                _repo.AddMeslekYuksekOkul(meslekYuksekOkul);
            else
                _repo.UpdateMeslekYuksekOkul(meslekYuksekOkul);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("MeslekYuksekOkullar");
            else
                return View(meslekYuksekOkul);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveMeslekYuksekOkul(int id)
        {
            _repo.RemoveMeslekYuksekOkul(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("MeslekYuksekOkullar");
        }

        #endregion

        #region Haber CRUD

        public IActionResult Haberler()
        {
            var haberler = _repo.GetAllHaberler();
            return View(haberler);
        }

        [HttpGet]
        public IActionResult EditHaberler(int? id)
        {
            if (id == null)
            {
                return View(new HaberViewModel());
            }
            else
            {
                var haber = _repo.GetHaber((int)id);
                return View(new HaberViewModel
                {
                    Id=haber.Id,
                    HaberBaslik=haber.HaberBaslik,
                    HaberAciklama=haber.HaberAciklama,
                    HaberKategori=haber.HaberKategori,
                    HaberTarih=haber.HaberTarih,
                    yukluHaberResim = haber.HaberResim
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditHaberler(HaberViewModel vm)
        {
            Haber haber = new Haber
            {
                Id = vm.Id,
                HaberBaslik = vm.HaberBaslik,
                HaberAciklama = vm.HaberAciklama,
                HaberKategori = vm.HaberKategori,
                HaberTarih = vm.HaberTarih
            };

            if (vm.HaberResim == null)
                haber.HaberResim = vm.yukluHaberResim;
            else
            {
                if (!string.IsNullOrEmpty(vm.yukluHaberResim))
                    _fileManager.RemoveImage(vm.yukluHaberResim);

                haber.HaberResim = await _fileManager.SaveImage(vm.HaberResim);
            }

            if (haber.Id == 0)
                _repo.AddHaber(haber);
            else
                _repo.UpdateHaber(haber);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Haberler");
            else
                return View(haber);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveHaber(int id)
        {
            _repo.RemoveHaber(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Haberler");
        }

        #endregion


    }
}
