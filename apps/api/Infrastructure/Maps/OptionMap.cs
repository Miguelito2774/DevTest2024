using api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Infrastructure.Maps;

public class OptionMap : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.HasMany(p => p.Votes).WithOne().HasForeignKey(p => p.OptionId).IsRequired();
    }
}
