using Microsoft.EntityFrameworkCore;
using PruebaTecnicaCovisian.Models;

namespace PruebaTecnicaCovisian.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alquiler>()
                .Property(a => a.ValorTotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Alquiler>()
                .Property(a => a.Saldo)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Alquiler>()
                .Property(a => a.Placa)
                .HasColumnType("text");

            modelBuilder.Entity<Alquiler>()
                .Property(a => a.Cedula)
                .HasColumnType("text");

            modelBuilder.Entity<Carro>()
                .Property(c => c.Placa)
                .HasColumnType("text");

            modelBuilder.Entity<Carro>()
                .Property(c => c.Marca)
                .HasColumnType("text");

            modelBuilder.Entity<Carro>()
                .Property(c => c.Modelo)
                .HasColumnType("text");

            modelBuilder.Entity<Carro>()
                .Property(c => c.Costo)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Carro>()
                .Property(c => c.Disponible)
                .HasColumnType("boolean");

            modelBuilder.Entity<Cliente>()
                .Property(cl => cl.Cedula)
                .HasColumnType("text");

            modelBuilder.Entity<Cliente>()
                .Property(cl => cl.Nombre)
                .HasColumnType("text");

            modelBuilder.Entity<Cliente>()
                .Property(cl => cl.Telefono1)
                .HasColumnType("text");

            modelBuilder.Entity<Cliente>()
                .Property(cl => cl.Telefono2)
                .HasColumnType("text");
        }
    }
}
