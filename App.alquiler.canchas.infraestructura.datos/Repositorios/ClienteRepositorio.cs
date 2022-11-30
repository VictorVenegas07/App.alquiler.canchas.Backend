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
    public class ClienteRepositorio : IRepositorioBase<Cliente>
    {
        private readonly CanchaContext context;
        public ClienteRepositorio(CanchaContext context_ )
        {
                context = context_;
        }
        public async Task<Cliente> AgregarAsync(Cliente entidad)
        {
            await  context.Clientes.AddAsync(entidad);
            return entidad;
        }

        public List<Cliente> Consultar(Func<Cliente, bool> exprecion)
        {
            var consulta =  context.Clientes
                .Include(x => x.Reservas)
                .Where(exprecion).ToList();
            return consulta;
        }

        public Cliente EditaAsync(Cliente entidad)
        {
            context.Clientes.Update(entidad);
            return entidad;
        }

        public async Task<bool> ExisteAsync(string identificacion)
        {
            return await context.Clientes.AnyAsync(x=> x.Identificacion == identificacion);
        }

        public async Task<List<Cliente>> ListarAsync()
        {
            return await context.Clientes.ToListAsync();
        }

        public async Task<Cliente> ObtenerPorIdAsync(int IdEntidad)
        {
            return await context.Clientes.FindAsync(IdEntidad);
        }
        public async Task GuardarCambiosAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
