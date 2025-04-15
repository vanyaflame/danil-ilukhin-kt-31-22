using WebApplication1.Database;
using WebApplication1.Filters.WorkTimeFilters;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Interfaces.WorkTimeInterfaces
{
    public interface IWorkTimeService
    {
        public Task<WorkTime[]> GetWorkTimeByProfessorAsync(WorkTimeProfessorFilter filter, CancellationToken cancellationToken);
        public Task<WorkTime[]> GetWorkTimeByCafedreAsync(WorkTimeCafedreFilter filter, CancellationToken cancellationToken);
        public Task<WorkTime[]> GetWorkTimeByDisciplineAsync(WorkTimeDisciplineFilter filter, CancellationToken cancellationToken);
        // public Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken);
    }

    public class WorkTimeService : IWorkTimeService
    {
        private readonly StudentDbContext _dbContext;
        public WorkTimeService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<WorkTime[]> GetWorkTimeByProfessorAsync(WorkTimeProfessorFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = _dbContext.Set<WorkTime>().Where(w => w.ProfessorId == filter.ProfessorId).ToArrayAsync(cancellationToken);

            return workTime;
        }
        public Task<WorkTime[]> GetWorkTimeByCafedreAsync(WorkTimeCafedreFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = _dbContext.Set<WorkTime>().Where(w => w.CafedreId == filter.CafedreId).ToArrayAsync(cancellationToken);

            return workTime;
        }
        public Task<WorkTime[]> GetWorkTimeByDisciplineAsync(WorkTimeDisciplineFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = _dbContext.Set<WorkTime>().Where(w => w.DisciplineId == filter.DisciplineId).ToArrayAsync(cancellationToken);

            return workTime;
        }

        //public Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken = default)
        //{
        //    var cafedres = _dbContext.Set<Cafedre>().Where(w => w.CafedreProfessorsAmount == filter.CafedreProfessorsAmount).ToArrayAsync(cancellationToken);

        //    return cafedres;
        //}

    }
}
