namespace api.Domain.Entities;

public class Vote : IEntity
{
    public int Id { get; set; }
    public int OptionId { get; set; }
}
