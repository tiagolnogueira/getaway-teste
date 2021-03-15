using Getaway.Teste.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Getaway.Teste.Application.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
