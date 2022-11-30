using App.canchas.Dominio.Entidades;
using App.canchas.Dominio.Interfaces.RepositoriosGenericos;
using App.canchas.infraestructura.datos.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.infraestructura.datos.Repositorios
{
    public class ReservaRepositori : IRepositorioReserva<FormularioReserva>
    {
        private readonly CanchaContext context;
        public ReservaRepositori(CanchaContext context_)
        {
            context = context_;
        }
        public async Task<FormularioReserva> AgregarAsync(FormularioReserva entidad)
        {
            await context.Reservas.AddAsync(entidad);
            return entidad;
        }

        public List<FormularioReserva> Consultar(Func<FormularioReserva, bool> exprecion)
        {
            var consulta = context.Reservas
              .Include(x => x.Cliente)
              .Include(x=> x.Cancha)
              .Include(x=> x.Pago)
              .Where(exprecion).ToList();
            return consulta;
        }

        public FormularioReserva EditaAsync(FormularioReserva entidad)
        {
            context.Reservas.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string exprecion)
        {
            return await context.Reservas.AnyAsync(x => x.Cliente.Identificacion== exprecion && x.Estado == "Pendiente");
        }

        public async Task<List<FormularioReserva>> ListarAsync()
        {
            return await context.Reservas.ToListAsync();
        }

        public async Task<FormularioReserva> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Reservas.FindAsync(IdEntidad);
        }
        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
