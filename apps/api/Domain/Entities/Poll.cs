namespace api.Domain.Entities;

public class Poll : IEntity
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public IList<Option> Options { get; set; } = [];
}
