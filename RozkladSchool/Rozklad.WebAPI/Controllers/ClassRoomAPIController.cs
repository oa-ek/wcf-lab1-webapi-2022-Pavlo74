using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.ClassDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomAPIController : ControllerBase
    {
        private readonly ClassRoomRepository classRoomApiRepository;
        private readonly ILogger<ClassRoomAPIController> _logger;
        public ClassRoomAPIController(ILogger<ClassRoomAPIController> logger, ClassRoomRepository classRoomApiRepository)
        {
            _logger = logger;
            this.classRoomApiRepository = classRoomApiRepository;
        }
        [HttpGet]
        public ClassRoomRepository GetClassRoomRepository()
        {
            return classRoomApiRepository;
        }


        [HttpGet("GetClassRoomListAsync")]
        public async Task<IEnumerable<ClassRoomReadDto>> GetListAsync()
        {
            return await classRoomApiRepository.GetListAsync();
        }
    }
}
