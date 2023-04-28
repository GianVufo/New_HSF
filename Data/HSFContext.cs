using Hsf_Receitas.Models;
using Microsoft.EntityFrameworkCore;

namespace Hsf_Receitas.Data
{
    public class HSFContext : DbContext
    {
        public HSFContext()
        {
            // Construtor
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("server=localhost;port=3306;database=hsf_Db;uid=root;SslMode=Preferred;ConvertZeroDateTime=true;pooling=no");
        }

        //server=mysql8003.site4now.net;port=3306;database=db_a98616_hsfdb;uid=a98616_hsfdb;password=Ann@1170615;SslMode=Preferred;ConvertZeroDateTime=true;pooling=no

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Medicacao>().ToTable("Medicamentos");
            modelBuilder.Entity<Receituario>().ToTable("Receitas");
             modelBuilder.Entity<AtestadoMedico>().ToTable("ATM");


        }

        public DbSet<Medicacao> Medicamentos { get; set; }
        public DbSet<Receituario> Receitas { get; set; }
         public DbSet<AtestadoMedico> AtestadosMedico { get; set; }

    }
    
}