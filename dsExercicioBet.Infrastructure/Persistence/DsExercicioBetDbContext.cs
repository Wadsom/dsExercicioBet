using System.Reflection;
using dsExercicioBet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dsExercicioBet.Infrastructure.Persistence;

public class DsExercicioBetDbContext: DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }
    public DbSet<Aposta> Apostas { get; set; }
    public DsExercicioBetDbContext(DbContextOptions<DsExercicioBetDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()));
    }
}