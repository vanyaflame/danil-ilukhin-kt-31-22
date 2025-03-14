using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;
using WebApplication1.Database.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class ScienceStateConfiguration : IEntityTypeConfiguration<ScienceState>
    {
        private const string TableName = "cd_science_state";

        public void Configure(EntityTypeBuilder<ScienceState> builder)
        {
            builder
                .HasKey(p => p.ScienceStateId)
                .HasName($"pk_{TableName}_science_state_id");

            builder.Property(p => p.ScienceStateId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ScienceStateId)
                .HasColumnName("science_state_id")
                .HasComment("Идентификатор записи научной степени");

            builder.Property(p => p.ScienceStateName)
                .IsRequired()
                .HasColumnName("c_science_state_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название научной степени");
        }
    }
}
