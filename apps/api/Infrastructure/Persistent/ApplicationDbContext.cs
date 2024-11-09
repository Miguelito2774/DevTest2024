using api.Application.Persistent;
using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Persistent;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options), IDbContext
{
    public DbSet<Poll> Polls { get; init; }
    public DbSet<Option> Options { get; init; }
    public DbSet<Vote> Votes { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
