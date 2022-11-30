using Microsoft.EntityFrameworkCore;
using System;
using App.canchas.Dominio.Entidades;

namespace App.canchas.infraestructura.datos.Contexto
{
    public class CanchaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Dueño> Dueños { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<FormularioReserva> Reservas { get; set; }
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = VICTOR; Database = canchasBDO; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Configuracion de reservas"
            modelBuilder
                .Entity<FormularioReserva>()
                .HasOne<Pago>(x => x.Pago)
                .WithOne(x => x.Reserva)
                .HasForeignKey<Pago>(x => x.IdPago);
            modelBuilder
                .Entity<FormularioReserva>()
                .HasOne<Cancha>(x => x.Cancha)
                .WithMany(x => x.Reservas)
                .HasForeignKey(x => x.IdCancha);

            modelBuilder
               .Entity<FormularioReserva>()
               .HasOne<Cliente>(x => x.Cliente)
               .WithMany(x => x.Reservas)
               .HasForeignKey(x => x.IdCliente);
            #endregion

            modelBuilder
                .Entity<Negocio>()
                .HasOne<Dueño>(x=> x.Dueño)
                .WithMany(x=> x.Negocios)
                .HasForeignKey(x=> x.IdDueño);

            modelBuilder
                .Entity<Cancha>()
                .HasOne<Negocio>(x => x.Negocio)
                .WithMany(x => x.Canchas)
                .HasForeignKey(x => x.IdNeogcio);

            modelBuilder
                .Entity<Administrador>()
                .HasOne<Usuario>(x=> x.Usuario)
                .WithOne(x=> x.Administrador)
                .HasForeignKey<Administrador>(x=>x.IdUsuario);

            modelBuilder
              .Entity<Dueño>()
              .HasOne<Usuario>(x => x.Usuario)
              .WithOne(x => x.Dueño)
              .HasForeignKey<Dueño>(x => x.IdUsuario);



        }
    }
}
