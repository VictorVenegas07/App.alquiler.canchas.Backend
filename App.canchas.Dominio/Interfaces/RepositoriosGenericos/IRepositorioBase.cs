using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Interfaces.RepositoriosGenericos
{
    public interface IRepositorioBase<T>
    {
        Task<T> AgregarAsync(T entidad);
        T EditaAsync(T entidad);
        List<T> Consultar(Func<T, bool> exprecion);
        Task<bool> ExisteAsync(string exprecion);
        Task<T> ObtenerPorIdAsync(int IdEntidad);
        Task<List<T>> ListarAsync();
        Task GuardarCambiosAsync();
    }
}
