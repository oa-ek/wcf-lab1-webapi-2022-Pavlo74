using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto.PupilDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilAPIController : ControllerBase
    {
        private readonly PupilRepository pupilApiRepository;
        private readonly ILogger<PupilAPIController> _logger;
        public PupilAPIController(ILogger<PupilAPIController> logger, PupilRepository pupilApiRepository)
        {
            _logger = logger;
            this.pupilApiRepository = pupilApiRepository;
        }
        [HttpGet]
        public PupilRepository GetPupilRepository()
        {
            return pupilApiRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetPupilListAsync")]
        public async Task<IEnumerable<PupilReadDto>> GetListAsync()
        {
            return await pupilApiRepository.GetListAsync();
        }
    }
}
