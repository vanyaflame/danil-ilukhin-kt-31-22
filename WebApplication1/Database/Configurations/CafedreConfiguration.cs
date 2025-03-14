using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;
using WebApplication1.Database.Helpers;

namespace WebApplication1.Database.Configurations
{
    public class CafedreConfiguration :IEntityTypeConfiguration<Cafedre>
    {
        // Название таблицы которое будет отображаться в БД
        private const string TableName = "cd_cafedre";

        public void Configure(EntityTypeBuilder<Cafedre> builder) 
        {
            // Задаем первичный ключ
            builder
                .HasKey(p => p.CafedreId)
                .HasName($"pk_{TableName}_cafedre_id");

            // Для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.CafedreId)
                .ValueGeneratedOnAdd();
            
            // Расписываем как будут называться колонки в БД, а так же их обязательность и тд
            builder.Property(p => p.CafedreId)
                .HasColumnName("cafedre_id")
                .HasComment("Идентификатор записи кафедры");

            // HasComment добавит комментарий, который будет отображаться в СУБД
            builder.Property(p => p.CafedreName)
                .IsRequired()
                .HasColumnName("c_cafedre_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название кафедры");

            builder.Property(p => p.CafedreCreationDate)
                .IsRequired()
                .HasColumnName("c_cafedre_creation_date")
                .HasColumnType(ColumnType.Int)
                .HasComment("Дата основания кафедры");

            builder.Property(p => p.CafedreMainProfessor)
                .IsRequired()
                .HasColumnName("c_cafedre_main_professor")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Старший преподаватель кафедры");

            builder.Property(p => p.ProfessorId)
                .IsRequired()
                .HasColumnName("f_professor_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("ID профессора");

            // Настройка таблицы и связей
            builder.ToTable(TableName)
                .HasMany(p => p.Professor)
                .WithOne()
                .HasForeignKey(p => p.ProfessorId)
                .HasConstraintName("fk_f_professor_id_cafedre")
                .OnDelete(DeleteBehavior.Cascade);

            // Индексы
            builder.HasIndex(p => p.ProfessorId, $"idx+{TableName}_fk_f_professor_id");

            // Автоподгрузка связанных сущностей
            builder.Navigation(p => p.Professor).AutoInclude();
        }
    }
}








