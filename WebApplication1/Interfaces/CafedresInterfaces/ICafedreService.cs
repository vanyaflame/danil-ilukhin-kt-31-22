using WebApplication1.Database;
using WebApplication1.Filters.CafedreFilters;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Interfaces.CafedresInterfaces
{
    public interface ICafedreService
    {
        public Task<Cafedre[]> GetCafedresByDateAsync(CafedreDateFilter filter, CancellationToken cancellationToken);
        public Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken);
    }

    public class CafedreService : ICafedreService
    {
        private readonly StudentDbContext _dbContext;
        public CafedreService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Cafedre[]> GetCafedresByDateAsync(CafedreDateFilter filter, CancellationToken cancellationToken = default)
        {
            var cafedres =_dbContext.Set<Cafedre>().Where(w => w.CafedreCreationDate == filter.CafedreCreationDate).ToArrayAsync(cancellationToken);

            return cafedres;
        }

        public Task<Cafedre[]> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken = default)
        {
            var cafedres = _dbContext.Set<Cafedre>().Where(w => w.CafedreProfessorsAmount == filter.CafedreProfessorsAmount).ToArrayAsync(cancellationToken);

            return cafedres;
        }

    }
}
