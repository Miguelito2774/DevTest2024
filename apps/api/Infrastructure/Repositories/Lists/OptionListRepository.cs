using api.Application.Repositories;
using api.Domain.Entities;

namespace api.Infrastructure.Lists;

public class OptionListRepository : IOptionRepository
{
    private readonly IList<Option> _options = [];
    
    public Task<string> Create(Option entity)
    {
        _options.Add(entity);
        
        return Task.FromResult("Option successfully created");
    }

    public Task<IList<Option>> GetAll()
    {
        return Task.FromResult(_options);
    }
}
