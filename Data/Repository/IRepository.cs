using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniTez.Data.Repository
{
    public interface IRepository
    {
        Duyuru GetDuyuru(int id);
        List<Duyuru> GetAllDuyurular();
        void AddDuyuru(Duyuru duyuru);
        void UpdateDuyuru(Duyuru duyuru);
        void RemoveDuyuru(int id);

        Etkinlik GetEtkinlik(int id);
        List<Etkinlik> GetAllEtkinlikler();
        void AddEtkinlik(Etkinlik etkinlik);
        void UpdateEtkinlik(Etkinlik etkinlik);
        void RemoveEtkinlik(int id);

        Task<bool> SaveChangesAsync();
    }
}
