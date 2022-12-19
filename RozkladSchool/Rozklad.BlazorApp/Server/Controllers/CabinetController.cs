using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetController : ControllerBase
    {
        private readonly CabinetRepository cabinetRepository;
        private readonly ILogger<CabinetController> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cabinetApiRepository"></param>
        public CabinetController(ILogger<CabinetController> logger, CabinetRepository cabinetRepository)
        {
            _logger = logger;
            this.cabinetRepository = cabinetRepository;
        }

        [HttpGet("/cabinets")]

        public CabinetRepository GetCabinetRepository()
        {
            return cabinetRepository;
        }


        [HttpGet("/cabinets")]
        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return await cabinetRepository.GetListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cabDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Cabinet> Create(CabinetCreateDto cabDto)
        {
            var createdCabinet = await cabinetRepository.AddCabinetByDtoAsync(cabDto);
            return createdCabinet;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cab"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task Edit(CabinetCreateDto cab)
        {
            await cabinetRepository.UpdateCabinetAsync(cab);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await cabinetRepository.DeleteCabinetAsync(id);
        }
    }
}
