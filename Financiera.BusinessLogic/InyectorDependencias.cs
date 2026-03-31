using Financiera.Data.Infrastructure;
using Financiera.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Financiera.BusinessLogic
{
    public static class InyectorDependencias
    {
        public static void Inyeccion(this IServiceCollection services)
        {
            services.AddScoped<ICliente, ClienteRepositorio>();
            services.AddScoped<ITipoCliente, TipoClienteRepositorio>();
            services.AddScoped<PrestamoServices>();
        }
    }
}
