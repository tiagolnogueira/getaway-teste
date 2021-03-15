using AutoMapper;
using Getaway.Teste.Api.ViewModels;
using Getaway.Teste.Domain.Entities;

namespace Getaway.Teste.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ProdutoViewModel, Produto>().ReverseMap(); ;
        }
    }
}