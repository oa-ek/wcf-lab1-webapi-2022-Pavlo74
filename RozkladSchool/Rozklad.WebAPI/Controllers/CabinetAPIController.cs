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

       
        [HttpGet("Get_Cabinet_List")]
        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return await cabinetApiRepository.GetListAsync();
        }

        [HttpPost]
        public async Task<Cabinet> Create(CabinetCreateDto cabDto)
        {
            var createdCabinet = await cabinetApiRepository.AddCabinetByDtoAsync(cabDto);
            return createdCabinet;
        }

        [HttpPut]
        public async Task Edit(CabinetCreateDto cab)
        {
            await cabinetApiRepository.UpdateCabinetAsync(cab);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await cabinetApiRepository.DeleteCabinetAsync(id);
        }

    }

    }

