using api.Domain.Entities;

namespace api.Application.Responses;

public class GetAllPollsResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public IList<Option> Options { get; init; } 

    public GetAllPollsResponse(Poll poll)
    {
        Id = poll.Id;
        Name = poll.Name;
        Options = poll.Options;
    }
    
}
