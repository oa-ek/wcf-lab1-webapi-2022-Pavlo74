using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        private readonly ILogger<TimetableController> _logger;
        // private readonly TimetableRepository ctx;
        private readonly TimetableRepository timetableRepository;
        //private readonly CabinetRepository cabinetsRepository;
        public TimetableController(TimetableRepository timetableRepository, ILogger<TimetableController> logger)
        {
            this.timetableRepository = timetableRepository;
            
            _logger = logger;
            

        }

      

        [HttpGet("/t")]
        public async Task<IActionResult> GetListAsync()
        {
            return Ok(await timetableRepository.GetListAsync());
        }
        
    }
}
