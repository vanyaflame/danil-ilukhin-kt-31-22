using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        private const string TableName = "cd_title";

        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(p => p.TitleId)
                .HasName($"pk_{TableName}_title_id");

            builder.Property(p => p.TitleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("title_id")
                .HasComment("Идентификатор записи должности");

            builder.Property(p => p.TitleName)
                .IsRequired()
                .HasColumnName("c_title_name")
                .HasMaxLength(100)
                .HasComment("Название должности");

            builder.ToTable(TableName);
        }
    }
}
