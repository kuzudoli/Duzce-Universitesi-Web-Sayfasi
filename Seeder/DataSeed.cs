using DuzceUniTez.Data;
using DuzceUniTez.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Seeder
{
    public static class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetService<AppDbContext>();

            //context.Database.Migrate();

            if (context.Fakulteler.Count() == 0)
            {
                context.Fakulteler.AddRange(
                    new List<Fakulte>() {
                         new Fakulte() { FakulteAd="Teknoloji Fakültesi", FakulteAciklama="Bilim ve Teknoloji", FakulteMail="DUtekFakulte@duzce.edu.tr",FakulteTel="03801234512" , FakulteAdres="Konuralp Duzce/Merkez"},
                         new Fakulte() { FakulteAd="Mühendlsik Fakültesi", FakulteAciklama="Yapay Zeka ve Derin Öğrenme", FakulteMail="DUmuhFakulte@duzce.edu.tr",FakulteTel="03801234534" , FakulteAdres="Konuralp Duzce/Merkez"},
                         new Fakulte() { FakulteAd="Hukuk Fakültesi", FakulteAciklama="Adalet ve Kanun", FakulteMail="DUhukFakulte@duzce.edu.tr",FakulteTel="03801234556" , FakulteAdres="Konuralp Duzce/Merkez"},
                    });
                context.Duyurular.AddRange(
                    new List<Duyuru>() {
                         new Duyuru() { DuyuruBaslik="Güz Dönemi Sınav Programı", DuyuruAciklama="Sınav programı açıklandı.", DuyuruTarih=Convert.ToDateTime("07-01-2022"),DuyuruResim="img_05-01-2022-00-53-08.jpg"},
                    });
            }
            context.SaveChanges();

        }
    }
}
