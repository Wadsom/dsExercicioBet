using dsExercicioBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsExercicioBet.Infrastructure.Configuration;

public class EventoModelBuilder:IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        builder.ToTable("Evento");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(e => e.Nome).IsRequired().HasMaxLength(50);
        builder.Property(e => e.Status).HasConversion<int>();
        builder.HasMany(evento=> evento.Apostas).WithOne(aposta => aposta.Evento).HasForeignKey(aposta=> aposta.IdEvento).OnDelete(DeleteBehavior.Restrict);
    }
}