using WebApplication1.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebApplication1.Filters.WorkTimeFilters;
using WebApplication1.Interfaces.WorkTimeInterfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkTimeController : ControllerBase
    {
        

        private readonly ILogger<WorkTimeController> _logger;
        private readonly IWorkTimeService _workTimeService;

        public WorkTimeController(ILogger<WorkTimeController> logger, IWorkTimeService workTimeService)
        {
            _logger = logger;
            _workTimeService = workTimeService; ;
        }

        [HttpPost("GetWorkTimeByProfessor")]
        public async Task<IActionResult> GetWorkTimeByProfessorAsync(WorkTimeProfessorFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = await _workTimeService.GetWorkTimeByProfessorAsync(filter, cancellationToken);

            return Ok(workTime);
        }

        //[HttpPost("GetCafedresByProfessorsAmount")]
        //public async Task<IActionResult> GetCafedresByProfessorsAmountAsync(CafedreProfessorsAmountFilter filter, CancellationToken cancellationToken = default)
        //{
        //    var cafedres = await _cafedreService.GetCafedresByProfessorsAmountAsync(filter, cancellationToken);

        //    return Ok(cafedres);
        //}

        [HttpPost("GetWorkTimeByCafedre")]
        public async Task<IActionResult> GetWorkTimeByCafedreAsync(WorkTimeCafedreFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = await _workTimeService.GetWorkTimeByCafedreAsync(filter, cancellationToken);

            return Ok(workTime);
        }

        [HttpPost("GetWorkTimeByDiscipline")]
        public async Task<IActionResult> GetWorkTimeByDisciplineAsync(WorkTimeDisciplineFilter filter, CancellationToken cancellationToken = default)
        {
            var workTime = await _workTimeService.GetWorkTimeByDisciplineAsync(filter, cancellationToken);

            return Ok(workTime);
        }
    }
}
