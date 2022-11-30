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
    public class DueñoRepositori:IRepositorioBase<Dueño>
    {
        private readonly CanchaContext context;
        public DueñoRepositori(CanchaContext context_)
        {
            context = context_;
        }
        public async Task<Dueño> AgregarAsync(Dueño entidad)
        {
            await context.Dueños.AddAsync(entidad);
            return entidad;
        }

        public List<Dueño> Consultar(Func<Dueño, bool> exprecion)
        {
            var consulta = context.Dueños
                .Include(x => x.Usuario)
                .Where(exprecion).ToList();
            return consulta;
        }

        public Dueño EditaAsync(Dueño entidad)
        {
            context.Dueños.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string identificacion)
        {
            return await context.Dueños.AnyAsync(x => x.Identificacion == identificacion);
        }

        public async Task<List<Dueño>> ListarAsync()
        {
            return await context.Dueños.ToListAsync();
        }
        public async Task<Dueño> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Dueños.FindAsync(IdEntidad);
        }
        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
