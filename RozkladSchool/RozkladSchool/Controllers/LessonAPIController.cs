using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Repositories;

namespace RozkladSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonAPIController : ControllerBase
    {
        private readonly LessonAPIRepository lessonApiRepository;
        public LessonAPIController(LessonAPIRepository lessonApiRepository)
        {

            this.lessonApiRepository = lessonApiRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<LessonReadDto>> GetListAsync()
        {
            return await lessonApiRepository.GetListAsync();
        }
    }
}
