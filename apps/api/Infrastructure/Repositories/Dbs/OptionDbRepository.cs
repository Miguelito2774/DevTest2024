using api.Application.Persistent;
using api.Application.Repositories;
using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Repositories.Dbs;

public class OptionDbRepository (IDbContext dbContext) : IOptionRepository
{
    public async Task<string> Create(Option entity)
    {
        await dbContext.Options.AddAsync(entity);
        
        await dbContext.SaveChangesAsync();
        
        return "Option added";
    }

    public async Task<IList<Option>> GetAll()
    {
        return await dbContext.Options.ToListAsync();
    }

    public async Task<bool> Exist(int id)
    {
        return await dbContext.Options.AnyAsync(x => x.Id == id);
    }
}
