﻿// <auto-generated />
using System;
using App.canchas.infraestructura.datos.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.canchas.infraestructura.datos.Migrations
{
    [DbContext(typeof(CanchaContext))]
    [Migration("20221128010426_FirtsMigration-2")]
    partial class FirtsMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Administrador", b =>
                {
                    b.Property<int>("IdAdministrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdministrador");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Cancha", b =>
                {
                    b.Property<int>("IdCancha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disponibilidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdNeogcio")
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCancha");

                    b.HasIndex("IdNeogcio");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Dueño", b =>
                {
                    b.Property<int>("IdDueño")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDueño");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("Dueños");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.FormularioReserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCancha")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdReserva");

                    b.HasIndex("IdCancha");

                    b.HasIndex("IdCliente");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Negocio", b =>
                {
                    b.Property<int>("IdNegocio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDueño")
                        .HasColumnType("int");

                    b.Property<string>("NombreNegocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCuenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNegocio");

                    b.HasIndex("IdDueño");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Pago", b =>
                {
                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<string>("Comprobante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.HasKey("IdPago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Administrador", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.Usuario", "Usuario")
                        .WithOne("Administrador")
                        .HasForeignKey("App.canchas.Dominio.Entidades.Administrador", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Cancha", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.Negocio", "Negocio")
                        .WithMany("Canchas")
                        .HasForeignKey("IdNeogcio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Negocio");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Dueño", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.Usuario", "Usuario")
                        .WithOne("Dueño")
                        .HasForeignKey("App.canchas.Dominio.Entidades.Dueño", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.FormularioReserva", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.Cancha", "Cancha")
                        .WithMany("Reservas")
                        .HasForeignKey("IdCancha")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.canchas.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cancha");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Negocio", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.Dueño", "Dueño")
                        .WithMany("Negocios")
                        .HasForeignKey("IdDueño")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dueño");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Pago", b =>
                {
                    b.HasOne("App.canchas.Dominio.Entidades.FormularioReserva", "Reserva")
                        .WithOne("Pago")
                        .HasForeignKey("App.canchas.Dominio.Entidades.Pago", "IdPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Cancha", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Dueño", b =>
                {
                    b.Navigation("Negocios");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.FormularioReserva", b =>
                {
                    b.Navigation("Pago");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Negocio", b =>
                {
                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("App.canchas.Dominio.Entidades.Usuario", b =>
                {
                    b.Navigation("Administrador");

                    b.Navigation("Dueño");
                });
#pragma warning restore 612, 618
        }
    }
}
