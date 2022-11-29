using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.TeacherDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAPIController : ControllerBase
    {
        private readonly TeacherRepository teacherApiRepository;
        private readonly ILogger<TeacherAPIController> _logger;
        public TeacherAPIController(ILogger<TeacherAPIController> logger, TeacherRepository teacherApiRepository)
        {
            _logger = logger;
            this.teacherApiRepository = teacherApiRepository;
        }
        [HttpGet]
        public TeacherRepository GetTeacherRepository()
        {
            return teacherApiRepository;
        }


        [HttpGet("GetTeacherListAsync")]
        public async Task<IEnumerable<TeacherReadDto>> GetListAsync()
        {
            return await teacherApiRepository.GetListAsync();
        }
    }
}
