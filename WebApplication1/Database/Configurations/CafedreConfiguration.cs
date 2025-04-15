using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Database.Configurations
{
    public class CafedreConfiguration : IEntityTypeConfiguration<Cafedre>
    {
        private const string TableName = "cd_cafedre";

        public void Configure(EntityTypeBuilder<Cafedre> builder)
        {
            builder.HasKey(p => p.CafedreId)
                .HasName($"pk_{TableName}_cafedre_id");

            builder.Property(p => p.CafedreId)
                .ValueGeneratedOnAdd()
                .HasColumnName("cafedre_id")
                .HasComment("Идентификатор записи кафедры");

            builder.Property(p => p.CafedreName)
                .IsRequired()
                .HasColumnName("c_cafedre_name")
                .HasMaxLength(100)
                .HasComment("Название кафедры");

            builder.Property(p => p.CafedreCreationDate)
                .IsRequired()
                .HasColumnName("c_cafedre_creation_date")
                .HasColumnType("INT")
                .HasComment("Дата основания кафедры");

            builder.Property(p => p.CafedreMainProfessor)
                .IsRequired()
                .HasColumnName("c_cafedre_main_professor")
                .HasMaxLength(100)
                .HasComment("Старший преподаватель кафедры");

            builder.Property(p => p.CafedreProfessorsAmount)
                .IsRequired()
                .HasColumnName("c_cafedre_professors_amount")
                .HasColumnType("INT")
                .HasComment("Количество профессоров");

            builder.ToTable(TableName);
        }
    }
}
