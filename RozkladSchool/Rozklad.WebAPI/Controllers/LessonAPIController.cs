using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonAPIController : ControllerBase
    {
        private readonly LessonRepository lessonApiRepository;
        private readonly ILogger<LessonAPIController> _logger;
        public LessonAPIController(ILogger<LessonAPIController> logger, LessonRepository lessonApiRepository)
        {
            _logger = logger;
            this.lessonApiRepository = lessonApiRepository;
        }
        [HttpGet]
        public LessonRepository GetLessonRepository()
        {
            return lessonApiRepository;
        }

        
        [HttpGet("GetLessonListAsync")]
        public async Task<IEnumerable<LessonReadDto>> GetListAsync()
        {
            return await lessonApiRepository.GetListAsync();
        }
    }
}
