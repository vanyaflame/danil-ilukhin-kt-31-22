using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;
using WebApplication1.Database.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class WorkTimeConfiguration : IEntityTypeConfiguration<WorkTime>
    {
        private const string TableName = "cd_work_time";

        public void Configure(EntityTypeBuilder<WorkTime> builder)
        {
            builder
                .HasKey(p => p.WorkTimeId)
                .HasName($"pk_{TableName}_work_time_id");

            builder.Property(p => p.WorkTimeId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.WorkTimeId)
                .HasColumnName("work_time_id")
                .HasComment("Идентификатор записи рабочего времени");

            builder.Property(p => p.WorkTimeHours)
                .IsRequired()
                .HasColumnName("c_work_time_hours")
                .HasColumnType(ColumnType.Int)
                .HasComment("Количество часов");

            builder.Property(p => p.ProfessorId)
                .IsRequired()
                .HasColumnName("f_professor_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID профессора");

            builder.ToTable(TableName)
                .HasMany(p => p.Professor)
                .WithOne()
                .HasForeignKey(p => p.ProfessorId)
                .HasConstraintName("fk_f_professor_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.CafedreId)
                .IsRequired()
                .HasColumnName("f_cafedre_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID кафедры");

            builder.ToTable(TableName)
                .HasMany(p => p.Cafedre)
                .WithOne()
                .HasForeignKey(p => p.CafedreId)
                .HasConstraintName("fk_f_cafedre_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.DisciplineId)
                .IsRequired()
                .HasColumnName("f_discipline_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID дисциплины");

            builder.ToTable(TableName)
                .HasMany(p => p.Discipline)
                .WithOne()
                .HasForeignKey(p => p.DisciplineId)
                .HasConstraintName("fk_f_discipline_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(p => p.ProfessorId, $"idx+{TableName}_fk_f_professor_id");
            builder.HasIndex(p => p.CafedreId, $"idx+{TableName}_fk_f_cafedre_id");
            builder.HasIndex(p => p.DisciplineId, $"idx+{TableName}_fk_f_discipline_id");

            builder.Navigation(p => p.Professor).AutoInclude();
            builder.Navigation(p => p.Cafedre).AutoInclude();
            builder.Navigation(p => p.Discipline).AutoInclude();

        }
    }
}
