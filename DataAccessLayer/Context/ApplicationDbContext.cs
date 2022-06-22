using EntityLayer.Entites;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class ApplicationDbContext : DbContext //Bu context in DbContext olduğunu belirttim
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-U45D5S4\\SQLEXPRESS;database=LibraryDB;integrated security=true;"); //Database ile bağlantının gerçekleştiği kısım

            optionsBuilder.EnableSensitiveDataLogging();
        }
        public DbSet<Book> Books { get; set; } //Dbsetlerimi girerek bağlantıyı sağladım
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            
        }
    }
}
