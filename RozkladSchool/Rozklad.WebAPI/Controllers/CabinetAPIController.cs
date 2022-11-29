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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCabinetListAsync")]
        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return await cabinetApiRepository.GetListAsync();
        }

        /*[HttpPost]
        public async Task<string> CreateAsync(CabinetCreateDto cab)
        {
            return await cabinetApiRepository.CreateAsync(cab);
        }*/
        /*[HttpPost]
        public async Task<Cabinet> AddCabinetAsync(Cabinet cab)
        {
            return await cabinetApiRepository.AddCabinetAsync(cab);
        }*/





    }

    }

