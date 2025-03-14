using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Database
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { 
        }
    }
}
