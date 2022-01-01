﻿using DuzceUniTez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniTez.Data.Repository
{
    public interface IRepository
    {

        //Duyuru Tablosuna Ait CRUD İşlemleri
        Duyuru GetDuyuru(int id);
        List<Duyuru> GetAllDuyurular();
        void AddDuyuru(Duyuru duyuru);
        void UpdateDuyuru(Duyuru duyuru);
        void RemoveDuyuru(int id);


        //Etkinlik Tablosuna Ait CRUD İşlemleri
        Etkinlik GetEtkinlik(int id);
        List<Etkinlik> GetAllEtkinlikler();
        void AddEtkinlik(Etkinlik etkinlik);
        void UpdateEtkinlik(Etkinlik etkinlik);
        void RemoveEtkinlik(int id);



        //Fakülte Tablosuna Ait CRUD İşlemleri
        Fakulte GetFakulte (int id);
        List<Fakulte> GetAllFakulteler ();
        void AddFakulte (Fakulte fakulte);
        void UpdateFakulte(Fakulte fakulte);
        void RemoveFakulte(int id);



        //Bölüm Tablosuna Ait CRUD İşlemleri
        Bolum GetBolum(int id);
        List<Bolum> GetAllBolumler();
        void AddBolum(Bolum bolum);
        void UpdateBolum(Bolum bolum);
        void RemoveBolum(int id);



        //Enstitu Tablosuna Ait CRUD İşlemleri
        Enstitu GetEnstitu(int id);
        List<Enstitu> GetAllEnstituler();
        void AddEnstitu(Enstitu fakulte);
        void UpdateEnstitu(Enstitu fakulte);
        void RemoveEnstitu(int id);


        Task<bool> SaveChangesAsync();
    }
}
