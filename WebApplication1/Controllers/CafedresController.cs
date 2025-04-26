using WebApplication1.Interfaces.CafedresInterfaces;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters.CafedreFilters;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CafedresController : ControllerBase
    {
        private readonly ILogger<CafedresController> _logger;
        private readonly ICafedreService _cafedreService;

        public CafedresController(ILogger<CafedresController> logger, ICafedreService cafedreService)
        {
            _logger = logger;
            _cafedreService = cafedreService;
        }

        [HttpPost("GetCafedresByDate")]
        public async Task<IActionResult> GetCafedresByDateAsync(CafedreDateFilter filter, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var cafedres = await _cafedreService.GetCafedresByDateAsync(filter, pageNumber, pageSize, cancellationToken);
            throw new Exception();
            return Ok(cafedres);
        }

        [HttpPost("GetCafedresByProfessorsAmount")]
        public async Task<IActionResult> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
        {
            var cafedres = await _cafedreService.GetCafedresByProfessorsAmountAsync(filter, pageNumber, pageSize, cancellationToken);
            return Ok(cafedres);
        }
    }
}
