using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.DisciplineDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineAPIController : ControllerBase
    {
        private readonly DisciplineRepository disciplineApiRepository;
        private readonly ILogger<DisciplineAPIController> _logger;
        public DisciplineAPIController(ILogger<DisciplineAPIController> logger, DisciplineRepository disciplineApiRepository)
        {
            _logger = logger;
            this.disciplineApiRepository = disciplineApiRepository;
        }
        [HttpGet]
        public DisciplineRepository GetDisciplineRepository()
        {
            return disciplineApiRepository;
        }


        [HttpGet("GetDisciplineListAsync")]
        public async Task<IEnumerable<DisciplineReadDto>> GetListAsync()
        {
            return await disciplineApiRepository.GetListAsync();
        }
    }
}
