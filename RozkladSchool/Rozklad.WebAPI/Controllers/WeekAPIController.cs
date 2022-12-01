using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeekAPIController : ControllerBase
    {
        private readonly WeekRepository weekApiRepository;
        private readonly ILogger<WeekAPIController> _logger;
        public WeekAPIController(ILogger<WeekAPIController> logger, WeekRepository weekApiRepository)
        {
            _logger = logger;
            this.weekApiRepository = weekApiRepository;
        }
        [HttpGet]
        public WeekRepository GetWeekRepository()
        {
            return weekApiRepository;
        }


        [HttpGet("Get_Week_List")]
        public async Task<IEnumerable<WeekReadDto>> GetListAsync()
        {
            return await weekApiRepository.GetListAsync();
        }

        [HttpPost]
        public async Task<Week> Create(WeekCreateDto weekDto)
        {
            var createdWeek = await weekApiRepository.AddWeekByDtoAsync(weekDto);
            return createdWeek;
        }

        [HttpPut]
        public async Task Edit(WeekCreateDto week)
        {
            await weekApiRepository.UpdateWeekAsync(week);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await weekApiRepository.DeleteWeekAsync(id);
        }
    }
}
