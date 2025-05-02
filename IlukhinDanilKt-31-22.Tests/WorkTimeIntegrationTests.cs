using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Interfaces.WorkTimeInterfaces;
using WebApplication1.Filters.WorkTimeFilters;
using WebApplication1.Models;

namespace IlukhinDanilKt_31_22.Tests
{
    public class WorkTimeIntegrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public WorkTimeIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
            .UseInMemoryDatabase(databaseName: "student_db")
            .Options;
        }

        [Fact]

        public async Task GetWorkTimeByProfessorAsync_5_OneObject()
        {
            var ctx = new StudentDbContext(_dbContextOptions);
            ctx.WorkTimes.RemoveRange(ctx.WorkTimes);
            await ctx.SaveChangesAsync();
            var workTimeService = new WorkTimeService(ctx);

            var workTimes = new List<WorkTime>()
            {
               new WorkTime
               {
                   WorkTimeHours = 120,
                   ProfessorId = 5,
                   CafedreId = 1,
                   DisciplineId = 1
               },
               new WorkTime
               {
                   WorkTimeHours = 130,
                   ProfessorId = 4,
                   CafedreId = 1,
                   DisciplineId = 1
               },
               new WorkTime
               {
                   WorkTimeHours = 140,
                   ProfessorId = 3,
                   CafedreId = 1,
                   DisciplineId = 1
               }
            };

            await ctx.Set<WorkTime>().AddRangeAsync(workTimes);
            await ctx.SaveChangesAsync();

            var filter = new WorkTimeProfessorFilter
            {
                ProfessorId = 5,
            };
            var workTimesResultProfessor = await workTimeService.GetWorkTimeByProfessorAsync(filter, CancellationToken.None);

            Assert.Single(workTimesResultProfessor);
        }

        [Fact]

        public async Task GetWorkTimeByCafedreAsync_2_OneObject()
        {
            var ctx = new StudentDbContext(_dbContextOptions);
            ctx.WorkTimes.RemoveRange(ctx.WorkTimes);
            await ctx.SaveChangesAsync();
            var workTimeService = new WorkTimeService(ctx);

            var workTimes = new List<WorkTime>()
            {
               new WorkTime
               {
                   WorkTimeHours = 120,
                   ProfessorId = 5,
                   CafedreId = 1,
                   DisciplineId = 1
               },
               new WorkTime
               {
                   WorkTimeHours = 130,
                   ProfessorId = 4,
                   CafedreId = 2,
                   DisciplineId = 1
               },
               new WorkTime
               {
                   WorkTimeHours = 140,
                   ProfessorId = 3,
                   CafedreId = 1,
                   DisciplineId = 1
               }
            };

            await ctx.Set<WorkTime>().AddRangeAsync(workTimes);
            await ctx.SaveChangesAsync();

            var filter = new WorkTimeCafedreFilter
            {
                CafedreId = 2,
            };
            var workTimesResult = await workTimeService.GetWorkTimeByCafedreAsync(filter, CancellationToken.None);

            Assert.Single(workTimesResult);
        }

        [Fact]

        public async Task GetWorkTimeByDisciplineAsync_2_OneObject()
        {
            var ctx = new StudentDbContext(_dbContextOptions);
            ctx.WorkTimes.RemoveRange(ctx.WorkTimes);
            await ctx.SaveChangesAsync();
            var workTimeService = new WorkTimeService(ctx);

            var workTimes = new List<WorkTime>()
            {
               new WorkTime
               {
                   WorkTimeHours = 120,
                   ProfessorId = 5,
                   CafedreId = 1,
                   DisciplineId = 2
               },
               new WorkTime
               {
                   WorkTimeHours = 130,
                   ProfessorId = 4,
                   CafedreId = 2,
                   DisciplineId = 1
               },
               new WorkTime
               {
                   WorkTimeHours = 140,
                   ProfessorId = 3,
                   CafedreId = 1,
                   DisciplineId = 1
               }
            };

            await ctx.Set<WorkTime>().AddRangeAsync(workTimes);
            await ctx.SaveChangesAsync();

            var filter = new WorkTimeDisciplineFilter
            {
                DisciplineId = 2,
            };
            var workTimesResult = await workTimeService.GetWorkTimeByDisciplineAsync(filter, CancellationToken.None);

            Assert.Single(workTimesResult);
        }
    }
}
