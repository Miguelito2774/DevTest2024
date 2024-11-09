using api.Application.Repositories;
using api.Domain.Entities;

namespace api.Infrastructure.Lists;

public class PollListRepository : IPollRepository
{
    private readonly IList<Poll> _polls = [];
    
    public Task<string> Create(Poll entity)
    {
        _polls.Add(entity);

        return Task.FromResult("Poll successfully created");
    }

    public Task<IList<Poll>> GetAll()
    {
        return Task.FromResult(_polls);
    }

    public Task<bool> Exist(int id)
    {
        return Task.FromResult(_polls.Any(p => p.Id == id));
    }
}
