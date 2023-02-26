using Games_EF_WinFormsApp.Constants;
using Games_EF_WinFormsApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games_EF_WinFormsApp.EntityMappings
{
    public class CreatorGameEntityMap : IEntityTypeConfiguration<CreatorGame>
    {
        public void Configure(EntityTypeBuilder<CreatorGame> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e => e.Name).HasMaxLength(DefaultDB.STRING_VALUE_MAX_LENGTH);
        }
    }
}
