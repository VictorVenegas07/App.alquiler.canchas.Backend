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
    public class CanchaRepositorio:IRepositorioBase<Cancha>
    {
        private readonly CanchaContext context;
        public CanchaRepositorio(CanchaContext context_)
        {
            context = context_;
        }
        public async Task<Cancha> AgregarAsync(Cancha entidad)
        {
            await context.Canchas.AddAsync(entidad);
            return entidad;
        }

        public List<Cancha> Consultar(Func<Cancha, bool> exprecion)
        {
            var consulta = context.Canchas
                .Include(x => x.Reservas)
                .Include(x=> x.Negocio)
                .Where(exprecion).ToList();
            return consulta;
        }

        public Cancha EditaAsync(Cancha entidad)
        {
            context.Canchas.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string identificacion)
        {
            return await context.Canchas.AnyAsync(x => x.Disponibilidad == identificacion);
        }

        public async Task<List<Cancha>> ListarAsync()
        {
            return await context.Canchas.ToListAsync();
        }

        public async Task<Cancha> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Canchas.FindAsync(IdEntidad);
        }
        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }

    }
}
