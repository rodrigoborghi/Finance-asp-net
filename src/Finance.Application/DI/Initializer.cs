
using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Infra.Context;
using Finance.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Finance.Application.DI {

    public class Initializer 
    {

        public static void Configure (IServiceCollection services, string conection) 
        {
            services.AddDbContext<AppDbContext> (options => options.UseSqlServer(conection));
            services.AddScoped (typeof (IRepository<Ativo>), typeof (AtivoRepository));
            services.AddScoped (typeof (IRepository<>), typeof (Repository<>));
            services.AddScoped (typeof (ICarteiraAtivosRepository), typeof(CarteiraAtivoRepository));
            services.AddScoped (typeof (AtivoService));
            services.AddScoped (typeof (AtivosCarteiraService));
            services.AddScoped (typeof (IUnitOfWork), typeof (UnitOfWork));
            
        }
    }
}  