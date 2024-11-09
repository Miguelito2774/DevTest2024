namespace api.Domain.Entities;

public class Option : IEntity
{
    public int Id { get; init; }
    public required string Name { get; set; }
    public required int PollId { get; init; }
    public required IList<Vote> Votes { get; set; }
    
}
