using WebApplication1.Interfaces.CafedresInterfaces;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
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
			_cafedreService = cafedreService; ;
		}

		[HttpPost("GetCafedresByDate")]
		public async Task<IActionResult> GetCafedresByDateAsync(CafedreDateFilter filter, CancellationToken cancellationToken = default)
		{
			var cafedres = await _cafedreService.GetCafedresByDateAsync(filter, cancellationToken);

			return Ok(cafedres);
		}

		[HttpPost("GetCafedresByProfessorsAmount")]
		public async Task<IActionResult> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken = default)
		{
			var cafedres = await _cafedreService.GetCafedresByProfessorsAmountAsync(filter, cancellationToken);

			return Ok(cafedres);
		}
	}
}
