using Getaway.Teste.Domain.Entities;
using Getaway.Teste.Infra.Context;
using Getaway.Teste.Infra.Interfaces;

namespace Getaway.Teste.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }
    }
}