using WebApplication1.Database;
using WebApplication1.Filters.CafedreFilters;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Interfaces.CafedresInterfaces
{
    public interface ICafedreService
    {
        public Task<Cafedre[]> GetCafedresByDateAsync(CafedreDateFilter filter, int pageNumber, int pageSize, CancellationToken cancellationToken);
        public Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, int pageNumber, int pageSize, CancellationToken cancellationToken);
    }

    public class CafedreService : ICafedreService
    {
        private readonly StudentDbContext _dbContext;
        public CafedreService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Cafedre[]> GetCafedresByDateAsync(CafedreDateFilter filter, int pageNumber, int pageSize, CancellationToken cancellationToken = default)
        {
            var startDate = filter.CafedreCreationDate.Date;
            var endDate = startDate.AddDays(1);

            var cafedres = await _dbContext.Set<Cafedre>()
                .Where(w => w.CafedreCreationDate >= startDate && w.CafedreCreationDate < endDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToArrayAsync(cancellationToken);

            return cafedres;
        }



        public async Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, int pageNumber, int pageSize, CancellationToken cancellationToken = default)
        {
            var cafedres = await _dbContext.Set<Cafedre>()
                .Where(w => w.CafedreProfessorsAmount == filter.CafedreProfessorsAmount)
                .Skip((pageNumber - 1) * pageSize)  // Пропускаем записи
                .Take(pageSize)                     // Ограничиваем выборку
                .ToArrayAsync(cancellationToken);

            return cafedres;
        }


    }
}
