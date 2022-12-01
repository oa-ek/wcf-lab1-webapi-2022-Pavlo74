using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
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


        [HttpGet("Get_Discipline_List")]
        public async Task<IEnumerable<DisciplineReadDto>> GetListAsync()
        {
            return await disciplineApiRepository.GetListAsync();
        }

        [HttpPost]
        public async Task<Discipline> Create(DisciplineCreateDto disciplineDto)
        {
            var disciplineCabinet = await disciplineApiRepository.AddDisciplineByDtoAsync(disciplineDto);
            return disciplineCabinet;
        }

        [HttpPut]
        public async Task Edit(DisciplineCreateDto discipline)
        {
            await disciplineApiRepository.UpdateDisciplineAsync(discipline);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await disciplineApiRepository.DeleteDisciplineAsync(id);
        }
    }
}
