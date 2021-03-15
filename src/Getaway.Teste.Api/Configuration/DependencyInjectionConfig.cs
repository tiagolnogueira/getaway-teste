using Getaway.Teste.Application.Interfaces;
using Getaway.Teste.Application.Notificacoes;
using Getaway.Teste.Application.Services;
using Getaway.Teste.Infra.Context;
using Getaway.Teste.Infra.Interfaces;
using Getaway.Teste.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Getaway.Teste.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
           
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
