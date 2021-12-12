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
        /*DUYURU*/
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

        /*ETKİNLİK*/

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


        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
                return true;

            return false;
        }
    }
}
