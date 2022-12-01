using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetAPIController : ControllerBase
    {

        private readonly CabinetRepository cabinetApiRepository;
        private readonly ILogger<CabinetAPIController> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cabinetApiRepository"></param>
        public CabinetAPIController(ILogger<CabinetAPIController> logger, CabinetRepository cabinetApiRepository)
        {
            _logger = logger;
            this.cabinetApiRepository = cabinetApiRepository;
        }
        
        [HttpGet]
        
        public CabinetRepository GetCabinetRepository()
        {
            return cabinetApiRepository;
        }

       
        [HttpGet("Get_Cabinet_List")]
        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return await cabinetApiRepository.GetListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cabDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Cabinet> Create(CabinetCreateDto cabDto)
        {
            var createdCabinet = await cabinetApiRepository.AddCabinetByDtoAsync(cabDto);
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
            await cabinetApiRepository.UpdateCabinetAsync(cab);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await cabinetApiRepository.DeleteCabinetAsync(id);
        }

    }

    }

