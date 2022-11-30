using App.canchas.Dominio.Interfaces.RepositoriosGenericos;
using App.canchas.Dominio.Interfaces.ServiciosGenericos;
using App.canchas.Dominio.Services;
using App.canchas.infraestructura.datos.Contexto;
using App.canchas.infraestructura.datos.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace App.chamchas.infraestructura.Api.dependency
{
    public static class Acancha
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<CanchaContext, CanchaContext>();
            services.AddTransient(typeof(IRepositorioBase<>), (typeof(IRepositorioBase<>)));

            //services.AddTransient(typeof(IRepositorioCancha<>));
            services.AddTransient(typeof(IRepositorioBase<>), (typeof(IRepositorioBase<>)));



            services.AddTransient<ReservaRepositori>();
            services.AddTransient<CanchaRepositorio>();
            services.AddTransient<ClienteRepositorio>();
            services.AddTransient<DueñoRepositori>();
            services.AddTransient<PagoRepositorio>();
            services.AddTransient<ReservaRepositori>();

            services.AddScoped<ServicioReserva>();
            return services;
        }
    }
}
