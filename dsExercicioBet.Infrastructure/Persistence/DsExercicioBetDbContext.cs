using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace dsExercicioBet.Infrastructure.Persistence;

public class DsExercicioBetDbContext: DbContext
{
    public DsExercicioBetDbContext(DbContextOptions<DsExercicioBetDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()));
    }
}