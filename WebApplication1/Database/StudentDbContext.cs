using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Database.Configurations;

namespace WebApplication1.Database
{
    public class StudentDbContext : DbContext
    {
        // Добавляем таблицы
        DbSet<Cafedre> Cafedres { get; set; }
        DbSet<Discipline> Disciplines { get; set; }
        DbSet<Professor> Professors { get; set; }
        DbSet<ScienceState> ScienceStates { get; set; }
        DbSet<Title> Titles { get; set; }
        DbSet<WorkTime> WorkTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new CafedreConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new ScienceStateConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new WorkTimeConfiguration());
        }


        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) 
        { 

        }
    }
}
