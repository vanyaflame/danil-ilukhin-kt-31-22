using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;
using WebApplication1.Database.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        private const string TableName = "cd_professor";

        public void Configure(EntityTypeBuilder<Professor> builder) 
        {
            builder
                .HasKey(p => p.ProfessorId)
                .HasName($"pk_{TableName}_professor_id");

            builder.Property(p => p.ProfessorId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ProfessorId)
                .HasColumnName("professor_id")
                .HasComment("Идентификатор записи профессора");

            builder.Property(p => p.ProfessorFirstName)
                .IsRequired()
                .HasColumnName("c_professor_first_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Имя профессора");

            builder.Property(p => p.ProfessorLastName)
                .IsRequired()
                .HasColumnName("c_professor_last_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Фамилия профессора");

            builder.Property(p => p.ProfessorMiddleName)
                .IsRequired()
                .HasColumnName("c_professor_middle_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Отчество профессора");

            builder.Property(p => p.ProfessorTitle)
                .IsRequired()
                .HasColumnName("c_professor_title")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Должность профессора");

            builder.Property(p => p.CafedreId)
                .IsRequired()
                .HasColumnName("f_cafedre_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID кафедры");

            builder.ToTable(TableName)
                .HasOne(p => p.Cafedre)
                .WithMany()
                .HasForeignKey(p => p.CafedreId)
                .HasConstraintName("fk_f_cafedre_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(p => p.CafedreId, $"idx+{TableName}_fk_f_cafedre_id");

            builder.Navigation(p => p.Cafedre).AutoInclude();

        }
    }
}
