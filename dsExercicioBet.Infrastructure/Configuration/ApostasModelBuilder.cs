using dsExercicioBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsExercicioBet.Infrastructure.Configuration;

public class ApostasModelBuilder : IEntityTypeConfiguration<Aposta>
{
    public void Configure(EntityTypeBuilder<Aposta> builder)
    {
        builder.ToTable("Apostas");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x=> x.Valor).HasColumnType("decimal(18,2)");
        builder.Property(x=> x.Odd).HasColumnType("decimal(18,2)");
        builder.Property(x=> x.Status).HasConversion<int>();
        builder.HasOne(aposta => aposta.Usuario).WithMany(u => u.Apostas).HasForeignKey(aposta => aposta.IdUsuario).OnDelete(DeleteBehavior.Restrict);
    }   
}