using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Interfaces.CafedresInterfaces;
using WebApplication1.Filters.CafedreFilters;
using WebApplication1.Models;

namespace IlukhinDanilKt_31_22.Tests
{
    public class CafedresIntegrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public CafedresIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
            .UseInMemoryDatabase(databaseName: "student_db")
            .Options;
        }

        [Fact]
        public async Task GetCafedresByDateAsync_20250205_OneObject()
        {
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var cafedreService = new CafedreService(ctx);

            var cafedres = new List<Cafedre>
            {
                new Cafedre
                {
                    CafedreName = "qwerty",
                    CafedreCreationDate = DateTime.Parse("2025-05-02T09:43:52.493Z"),
                    CafedreMainProfessor = "zxc",
                    CafedreProfessorsAmount = 1,
                },
                new Cafedre
                {
                    CafedreName = "qwerty2",
                    CafedreCreationDate = DateTime.Parse("2025-05-01T00:00:00.000Z"),
                    CafedreMainProfessor = "zxc2",
                    CafedreProfessorsAmount = 2,
                },
                new Cafedre
                {
                    CafedreName = "qwerty3",
                    CafedreCreationDate = DateTime.Parse("2025-05-01T00:00:00.000Z"),
                    CafedreMainProfessor = "zxc3",
                    CafedreProfessorsAmount = 1,
                }
            };
            await ctx.Set<Cafedre>().AddRangeAsync(cafedres);
            await ctx.SaveChangesAsync();

            // Проверка, что данные сохранились
            var savedCafedres = await ctx.Cafedres.ToListAsync();

            // Act
            var filter = new CafedreDateFilter
            {
                CafedreCreationDate = DateTime.Parse("2025-05-02T00:00:00.000Z"),
            };
            var cafedresResult = await cafedreService.GetCafedresByDateAsync(filter, 1, 10, CancellationToken.None);

            // Assert
            Assert.Single(cafedresResult); // Должна вернуться только одна запись (qwerty)
        }

        [Fact]
        public async Task GetCafedresByProfessorsAmountAsync_5_OneObject()
        {
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var cafedreService = new CafedreService(ctx);

            var cafedres = new List<Cafedre>
            {
                new Cafedre
                {
                    CafedreName = "qwerty",
                    CafedreCreationDate = DateTime.Parse("2025-05-02T09:43:52.493Z"),
                    CafedreMainProfessor = "zxc",
                    CafedreProfessorsAmount = 5,
                },
                new Cafedre
                {
                    CafedreName = "qwerty2",
                    CafedreCreationDate = DateTime.Parse("2025-05-01T00:00:00.000Z"),
                    CafedreMainProfessor = "zxc2",
                    CafedreProfessorsAmount = 1,
                },
                new Cafedre
                {
                    CafedreName = "qwerty3",
                    CafedreCreationDate = DateTime.Parse("2025-05-01T00:00:00.000Z"),
                    CafedreMainProfessor = "zxc3",
                    CafedreProfessorsAmount = 1,
                }
            };
            await ctx.Set<Cafedre>().AddRangeAsync(cafedres);
            await ctx.SaveChangesAsync();

            // Act
            var filter = new CafedreProfessorsAmountFilter
            {
                CafedreProfessorsAmount = 5,
            };
            var cafedresResult = await cafedreService.GetCafedresByProfessorsAmountAsync(filter, 1, 10, CancellationToken.None);

            // Assert
            Assert.Single(cafedresResult); // Должна вернуться только одна запись (qwerty)
        }
    }
}

