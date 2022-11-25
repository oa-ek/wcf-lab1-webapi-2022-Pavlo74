using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace RozkladSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableAPIController : ControllerBase
    {
        private readonly TimetableAPIRepository timetableApiRepository;
        public TimetableAPIController(TimetableAPIRepository timetableApiRepository)
        {

            this.timetableApiRepository = timetableApiRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return await timetableApiRepository.GetListAsync();
        }
    }
}
