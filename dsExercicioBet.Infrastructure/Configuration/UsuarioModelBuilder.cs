using dsExercicioBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsExercicioBet.Infrastructure.Configuration;

public class UsuarioModelBuilder: IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x=> x.Nome).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Senha).HasMaxLength(512).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Email).HasMaxLength(30).IsRequired();
        builder.Property(x=>x.Cargo).HasMaxLength(20).IsRequired();
        builder.HasMany(x=> x.Apostas).WithOne(aposta=> aposta.Usuario).HasForeignKey(aposta=> aposta.Id).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(user=> user.Transacaos).WithOne(transacao => transacao.Cliente).HasForeignKey(tra=> tra.IdCliente).OnDelete(DeleteBehavior.Restrict);
    }
}