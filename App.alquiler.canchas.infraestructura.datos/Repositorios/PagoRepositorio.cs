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
    public class PagoRepositorio : IRepositorioBase<Pago>
    {
        private readonly CanchaContext context;
        public PagoRepositorio(CanchaContext context_)
        {
            context = context_;
        }
        public async Task<Pago> AgregarAsync(Pago entidad)
        {
            await context.Pagos.AddAsync(entidad);
            return entidad;
        }

        public List<Pago> Consultar(Func<Pago, bool> exprecion)
        {
            var consulta = context.Pagos
               .Include(x => x.Reserva)
               .Where(exprecion).ToList();
            return consulta;
        }

        public Pago EditaAsync(Pago entidad)
        {
            context.Pagos.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string exprecion)
        {
            return await context.Pagos.AnyAsync(x => x.ReferenciaPago == exprecion);
        }

        public async Task<List<Pago>> ListarAsync()
        {
            return await context.Pagos.ToListAsync();
        }

        public async Task<Pago> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Pagos.FindAsync(IdEntidad);
        }
        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
