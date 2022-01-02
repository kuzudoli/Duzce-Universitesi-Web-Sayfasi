using DuzceUniTez.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniTez.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Duyuru> Duyurular { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Enstitu> Enstituler { get; set; }
        public DbSet<YuksekOkul> YuksekOkullar { get; set; }
        public DbSet<MeslekYuksekOkul> MeslekYuksekOkullar { get; set; }
        public DbSet<Haber> Haberler { get; set; }
    }
}
