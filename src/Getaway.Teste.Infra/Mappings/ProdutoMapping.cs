using Getaway.Teste.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Getaway.Teste.Infra.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("decimal(15,2)");

            builder.ToTable("Produtos");
        }
    }
}
