using api.Domain.Entities;

namespace api.Application.Repositories;

public interface IOptionRepository: IRepository<Option>
{
    async Task<IDictionary<int, List<Option>>> GroupOptionsByPoll()
    {
        IList<Option> options = await GetAll();
        IDictionary<int, List<Option>> groups = options.GroupBy(o => o.PollId).ToDictionary(static g => g.Key, 
            g => g.ToList());
        
        return groups;
    }
}
