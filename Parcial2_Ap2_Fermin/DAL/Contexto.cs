using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_Ap2_Fermin.DAL
{
    public class Contexto : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder dbContext)
        {
            dbContext.UseSqlite(@"Data Source = DATA\SegundoParcial.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            
        }
    }
}
