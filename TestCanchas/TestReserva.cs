using App.canchas.Dominio.Entidades;
using App.canchas.Dominio.Services;
using App.canchas.infraestructura.datos.Contexto;
using App.canchas.infraestructura.datos.Repositorios;
using App.chamchas.infraestructura.Api.Controllers;
using System;
using Xunit;

namespace TestCanchas
{
    public class TestReserva
    {
        private readonly ReservaController controller;
        public TestReserva()
        {
            controller = new ReservaController(new CanchaContext());
        }
        [Fact]
        public async void TestReservaInput()
        {
            FormularioReserva reserva = new FormularioReserva()
            {
                FechaReserva = DateTime.Now,
                Comentario = "Ninguno",
                IdCancha = 1,
                Estado = "Pendiente",
                Pago = new Pago()
                {
                    ReferenciaPago = "HAS2122",
                    FechaPago = DateTime.Now,
                    Comprobante = "Ninguno",
                },
                Cliente = new Cliente
                {
                    TipoDocumento = "CC",
                    Nombres = "Bladimir Jesus",
                    Apellidos = "Vargas Rios",
                    Edad = 20,
                    Telefono = "302122234",
                    Email = "bjvargas@unicesar.edu.co",
                    Ciudad = "Valledupar",
                    Departamento = "Cesar",
                }

            };
            
            await controller.Post(reserva);
        }
    }
}

