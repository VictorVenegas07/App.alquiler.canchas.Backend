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
    public class AdministradorRepositorio:IRepositorioBase<Administrador>
    {
        private readonly CanchaContext context;
        public AdministradorRepositorio(CanchaContext context_)
        {
            context = context_;
        }
        public async Task<Administrador> AgregarAsync(Administrador entidad)
        {
            await context.Administradores.AddAsync(entidad);
            return entidad;
        }

        public List<Administrador> Consultar(Func<Administrador, bool> exprecion)
        {
            var consulta = context.Administradores
                .Include(x => x.Usuario)
                .Where(exprecion).ToList();
            return consulta;
        }

        public Administrador EditaAsync(Administrador entidad)
        {
            context.Administradores.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string identificacion)
        {
            return await context.Administradores.AnyAsync(x => x.Identificacion == identificacion);
        }

        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task<List<Administrador>> ListarAsync()
        {
           return await context.Administradores.ToListAsync();
        }

        public async Task<Administrador> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Administradores.FindAsync(IdEntidad);
        }
    }
}
