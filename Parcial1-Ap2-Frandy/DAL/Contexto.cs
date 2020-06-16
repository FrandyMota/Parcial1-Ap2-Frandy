using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Frandy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Frandy.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Parcial1-Ap2-Frandy\Parcial.db");
        }
    }
}
