using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Infrastructure.Maps;

public class PollMap : IEntityTypeConfiguration<Poll>
{
    public void Configure(EntityTypeBuilder<Poll> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.HasMany(p => p.Options).WithOne().HasForeignKey(p => p.PollId).IsRequired();
    }
}
