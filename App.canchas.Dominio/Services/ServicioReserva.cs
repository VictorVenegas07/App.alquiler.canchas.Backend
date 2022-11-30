using App.canchas.Dominio.Entidades;
using App.canchas.Dominio.Interfaces.RepositoriosGenericos;
using App.canchas.Dominio.Interfaces.ServiciosGenericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Services
{
    public class ServicioReserva : IServiceBase<FormularioReserva>
    {
        private readonly IRepositorioReserva<FormularioReserva> repositorio;
        private readonly IRepositorioBase<Cliente> repositorioCliente;
        private readonly IRepositorioBase<Cancha> repositoriocancha;
        private readonly IRepositorioBase<Pago> repositorioPago;

        public ServicioReserva(
            IRepositorioReserva<FormularioReserva> repositorio_, 
            IRepositorioBase<Cliente> repositorioCliente_,
            IRepositorioBase<Cancha> cancha_,
            IRepositorioBase<Pago> repositorioPago_
            )
        {
            repositorio = repositorio_;
            repositorioCliente = repositorioCliente_;
            repositoriocancha = cancha_;
            repositorioPago = repositorioPago_;
        }
        public async Task<FormularioReserva> AgregarAsync(FormularioReserva entidad)
        {
            ValidarCliente(entidad);
            await ValidarDisponibilidadCancha(entidad);
            await ValidarExistenciaReserva(entidad);
            await ValidarPago(entidad);
            await repositorio.AgregarAsync(entidad);
            await repositorio.GuardarCambiosAsync();
            return entidad;

        }
        private async Task ValidarExistenciaReserva(FormularioReserva reserva)
        {
            var response = await repositorio.ExisteAsync(reserva.Cliente.Identificacion);
            if(response)
                throw new ExepcionsValidations($"el cliente {reserva.Cliente.Nombres} ya tiene una reserva");

        }
        private void ValidarCliente(FormularioReserva reserva)
        {
            var cliente = repositorioCliente.Consultar(x => x.Identificacion == reserva.Cliente.Identificacion).FirstOrDefault();
            if (cliente is not null)
                reserva.Cliente = cliente;
        }
        private async Task ValidarDisponibilidadCancha(FormularioReserva reserva)
        {
            var cancha = await repositoriocancha.ObtenerPorIdAsync(reserva.IdCancha);
            if (cancha is null || cancha.Disponibilidad.Equals("Ocupada"))
                throw new ExepcionsValidations("La cancha no es valida");
        }

        private async Task ValidarPago(FormularioReserva reserva)
        {
            var pago = await repositorioPago.ExisteAsync(reserva.Pago.ReferenciaPago);
            if (pago)
               throw new ExepcionsValidations("El pago no es valido");
        }

        public List<FormularioReserva> Consultar(Func<FormularioReserva, bool> exprecion)
        {
            var response = repositorio.Consultar(exprecion);
            return response;
        }

        public FormularioReserva EditaAsync(FormularioReserva entidad)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FormularioReserva>> Listar()
        {
           var reservas = await repositorio.ListarAsync();
            return reservas;
        }
    }
}
