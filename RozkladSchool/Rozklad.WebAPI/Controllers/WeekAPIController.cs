using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


        [HttpGet("GetWeekListAsync")]
        public async Task<IEnumerable<WeekReadDto>> GetListAsync()
        {
            return await weekApiRepository.GetListAsync();
        }

        //[HttpPost]
        //public async Task<Cabinet> Create(CabinetCreateDto cabDto)
        //{
           // var createdCabinet = await cabinetApiRepository.AddCabinetByDtoAsync(cabDto);
            //return createdCabinet;
        //}

        //[HttpPut]
        //public async Task Edit(CabinetCreateDto cab)
        //{
            //await cabinetApiRepository.UpdateCabinetAsync(cab);
       // }

       // [HttpDelete("{id}")]
       // public async Task Delete(int id)
        //{
           // await cabinetApiRepository.DeleteCabinetAsync(id);
        //}
    }
}
