using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;//SQL benzeri tek bir söz dizimi sağlar
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniTez.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }


        #region Duyurular
        public void AddDuyuru(Duyuru duyuru)
        {
            _ctx.Duyurular.Add(duyuru);
        }

        public List<Duyuru> GetAllDuyurular()
        {
            return _ctx.Duyurular.ToList();
        }

        public Duyuru GetDuyuru(int id)
        {
            //Linq
            return _ctx.Duyurular.FirstOrDefault(d => d.Id == id);
        }

        public void RemoveDuyuru(int id)
        {
            _ctx.Duyurular.Remove(GetDuyuru(id));
        }

        public void UpdateDuyuru(Duyuru duyuru)
        {
            _ctx.Duyurular.Update(duyuru);
        }
        #endregion


        #region Etkinlikler
        public void AddEtkinlik(Etkinlik etkinlik)
        {
            _ctx.Etkinlikler.Add(etkinlik);
        }

        public List<Etkinlik> GetAllEtkinlikler()
        {
            return _ctx.Etkinlikler.ToList();
        }

        public Etkinlik GetEtkinlik(int id)
        {
            //Linq
            return _ctx.Etkinlikler.FirstOrDefault(d => d.Id == id);
        }

        public void RemoveEtkinlik(int id)
        {
            _ctx.Etkinlikler.Remove(GetEtkinlik(id));
        }

        public void UpdateEtkinlik(Etkinlik etkinlik)
        {
            _ctx.Etkinlikler.Update(etkinlik);
        }
        #endregion


        #region Fakulteler
        public void AddFakulte(Fakulte fakulte)
        {
            _ctx.Fakulteler.Add(fakulte);
        }

        public void UpdateFakulte(Fakulte fakulte)
        {
            _ctx.Fakulteler.Update(fakulte);
        }

        public void RemoveFakulte(int id)
        {
            _ctx.Fakulteler.Remove(GetFakulte(id));
        }

        public Fakulte GetFakulte(int id)
        {
            return _ctx.Fakulteler.FirstOrDefault(d => d.Id == id);
        }

        public List<Fakulte> GetAllFakulteler()
        {
            return _ctx.Fakulteler.ToList();
        }

        #endregion


        #region Bölümler
        public Bolum GetBolum(int id)
        {
            return _ctx.Bolumler.FirstOrDefault(d => d.Id == id);
        }

        public List<Bolum> GetAllBolumler()
        {
            return _ctx.Bolumler.ToList();
        }

        public void AddBolum(Bolum bolum)
        {
            //bolum.FakulteId = (from g in _ctx.Fakulteler where g.FakulteAd == bolum.Fakultesi select g.Id).FirstOrDefault();
            _ctx.Bolumler.Add(bolum);
        }

        public void UpdateBolum(Bolum bolum)
        {
            _ctx.Bolumler.Update(bolum);
        }

        public void RemoveBolum(int id)
        {
            _ctx.Bolumler.Remove(GetBolum(id));
        }
        #endregion


        #region Enstituler
        public Enstitu GetEnstitu(int id)
        {
            return _ctx.Enstituler.FirstOrDefault(d => d.Id == id);
        }

        public List<Enstitu> GetAllEnstituler()
        {
            return _ctx.Enstituler.ToList();
        }

        public void AddEnstitu(Enstitu enstitu)
        {
            _ctx.Enstituler.Add(enstitu);
        }

        public void UpdateEnstitu(Enstitu enstitu)
        {
            _ctx.Enstituler.Update(enstitu);
        }

        public void RemoveEnstitu(int id)
        {
            _ctx.Enstituler.Remove(GetEnstitu(id));
        }
        #endregion


        #region YüksekOkullar
        public YuksekOkul GetYuksekOkul(int id)
        {
            return _ctx.YuksekOkullar.FirstOrDefault(d => d.Id == id);
        }

        public List<YuksekOkul> GetAllYuksekOkullar()
        {
            return _ctx.YuksekOkullar.ToList();
        }

        public void AddYuksekOkul(YuksekOkul yuksekOkul)
        {
            _ctx.YuksekOkullar.Add(yuksekOkul);
        }

        public void UpdateYuksekOkul(YuksekOkul yuksekOkul)
        {
            _ctx.YuksekOkullar.Update(yuksekOkul);
        }

        public void RemoveYuksekOkul(int id)
        {
            _ctx.YuksekOkullar.Remove(GetYuksekOkul(id));
        }
        #endregion


        #region MeslekYüksekOkullar
        public MeslekYuksekOkul GetMeslekYuksekOkul(int id)
        {
            return _ctx.MeslekYuksekOkullar.FirstOrDefault(d => d.Id == id);
        }

        public List<MeslekYuksekOkul> GetAllMeslekYuksekOkullar()
        {
            return _ctx.MeslekYuksekOkullar.ToList();
        }

        public void AddMeslekYuksekOkul(MeslekYuksekOkul meslekYuksekOkul)
        {
            _ctx.MeslekYuksekOkullar.Add(meslekYuksekOkul);
        }

        public void UpdateMeslekYuksekOkul(MeslekYuksekOkul meslekYuksekOkul)
        {
            _ctx.MeslekYuksekOkullar.Update(meslekYuksekOkul);
        }

        public void RemoveMeslekYuksekOkul(int id)
        {
            _ctx.MeslekYuksekOkullar.Remove(GetMeslekYuksekOkul(id));
        }
        #endregion


        #region Haberler
        public Haber GetHaber(int id)
        {
            return _ctx.Haberler.FirstOrDefault(d => d.Id == id);
        }

        public List<Haber> GetAllHaberler()
        {
            return _ctx.Haberler.ToList();
        }

        public void AddHaber(Haber haber)
        {
            _ctx.Haberler.Add(haber);
        }

        public void UpdateHaber(Haber haber)
        {
            _ctx.Haberler.Update(haber);
        }

        public void RemoveHaber(int id)
        {
            _ctx.Haberler.Remove(GetHaber(id));
        }

        #endregion



        #region Senkronizasyon
        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
