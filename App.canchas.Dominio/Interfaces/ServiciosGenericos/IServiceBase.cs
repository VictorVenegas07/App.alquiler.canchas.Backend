using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Interfaces.ServiciosGenericos
{
    public interface IServiceBase<T>
    {
        Task<T> AgregarAsync(T entidad);
        T EditaAsync(T entidad);
        List<T> Consultar(Func<T, bool> exprecion);
        Task<List<T>> Listar();


    }
}
