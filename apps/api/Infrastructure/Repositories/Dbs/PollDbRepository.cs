using api.Application.Persistent;
using api.Application.Repositories;
using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Repositories.Dbs;

public class PollDbRepository(IDbContext dbContext) : IPollRepository
{
    public async Task<string> Create(Poll entity)
    {
        await dbContext.Polls.AddAsync(entity);
        
        await dbContext.SaveChangesAsync();

        return "Poll successfully created.";
    }

    public async Task<IList<Poll>> GetAll()
    {
        return await dbContext.Polls.ToListAsync();
    }

    public async Task<bool> Exist(int id)
    {
        return await dbContext.Polls.AnyAsync(p => p.Id == id);
    }
}

