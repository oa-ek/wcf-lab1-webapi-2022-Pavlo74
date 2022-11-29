using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableApiController : ControllerBase
    {
        private readonly TimetableRepository timetableApiRepository;
        private readonly ILogger<TimetableApiController> _logger;
        public TimetableApiController(ILogger<TimetableApiController> logger, TimetableRepository timetableApiRepository)
        {
            _logger = logger;
            this.timetableApiRepository = timetableApiRepository;
        }
        [HttpGet]
        public TimetableRepository GetTimetableRepository()
        {
            return timetableApiRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetTimetableListAsync")]
        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return await timetableApiRepository.GetListAsync();
        }
    }
}
