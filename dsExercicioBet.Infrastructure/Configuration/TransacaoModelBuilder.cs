using dsExercicioBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsExercicioBet.Infrastructure.Configuration;

public class TransacaoModelBuilder:IEntityTypeConfiguration<Transacao>
{
    public void Configure(EntityTypeBuilder<Transacao> builder)
    {
        builder.ToTable("Transacao");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id")
            .ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(tra => tra.Valor).HasColumnName("Valor").HasColumnType("decimal(18,2)");
        builder.HasOne(tra=>tra.Cliente).WithMany(user=> user.Transacaos).HasForeignKey(x=> x.IdCliente).OnDelete(DeleteBehavior.Restrict);
    }
}