using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Application.Persistent;

public interface IDbContext
{
    DbSet<Poll> Polls { get;}
    DbSet<Option> Options { get;}
    DbSet<Vote> Votes { get;}
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
