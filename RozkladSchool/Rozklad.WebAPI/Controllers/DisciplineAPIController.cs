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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="disciplineApiRepository"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disciplineDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Discipline> Create(DisciplineCreateDto disciplineDto)
        {
            var disciplineCabinet = await disciplineApiRepository.AddDisciplineByDtoAsync(disciplineDto);
            return disciplineCabinet;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="discipline"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task Edit(DisciplineCreateDto discipline)
        {
            await disciplineApiRepository.UpdateDisciplineAsync(discipline);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await disciplineApiRepository.DeleteDisciplineAsync(id);
        }
    }
}
