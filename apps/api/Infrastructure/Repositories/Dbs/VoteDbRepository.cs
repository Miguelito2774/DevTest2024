using api.Application.Persistent;
using api.Application.Repositories;
using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Repositories.Dbs;

public class VoteDbRepository (IDbContext dbContext) : IVoteRepository
{
    public async Task<string> Create(Vote entity)
    {
        await dbContext.Votes.AddAsync(entity);
        
        await dbContext.SaveChangesAsync();
        
        return "Vote added";
        
    }

    public async Task<IList<Vote>> GetAll()
    {
        return await dbContext.Votes.ToListAsync();
    }
}
