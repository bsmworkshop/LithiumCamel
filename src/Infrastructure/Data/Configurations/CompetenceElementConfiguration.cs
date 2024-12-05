using LithiumCamel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LithiumCamel.Infrastructure.Data.Configurations
{
    public class CompetenceElementConfiguration : IEntityTypeConfiguration<CompetenceElement>
    {
        public void Configure(EntityTypeBuilder<CompetenceElement> builder)
        {
            builder
                .ToTable("CompetenceElement");
                
        }
    }
}
