using Core_Proje_API.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_API.DataAccessLayer.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-BR4E36S8;database=CoreProjectDBAPI;user=sa;password=berkay345..;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
