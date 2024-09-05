using Microsoft.EntityFrameworkCore;
using parcialUno.shared.Entities;
using System.Security.Cryptography.X509Certificates;

namespace parcialUno.API.Data
{
    public class DataContext : DbContext
    {
        DbSet<Paciente> pacientes { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.Nombre).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.ApellidoMaterno).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.ApellidoPaterno).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.ApellidoMaterno).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.Celular).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>().HasIndex(x => x.HistorialClinico).IsUnique();




        }
    } 
}
