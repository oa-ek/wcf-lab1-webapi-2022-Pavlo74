using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.PupilDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("Api/[controller]")]
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
        [HttpGet("Get_Pupil_List")]
        public async Task<IEnumerable<PupilReadDto>> GetListAsync()
        {
            return await pupilApiRepository.GetListAsync();
        }

        [HttpPost]
        public async Task<Pupil> Create(PupilCreateDto pupilDto)
        {
            var createdPupil = await pupilApiRepository.AddPupilByDtoAsync(pupilDto);
            return createdPupil;
        }

        [HttpPut]
        public async Task Edit(PupilCreateDto pupil)
        {
            await pupilApiRepository.UpdatePupilAsync(pupil);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await pupilApiRepository.DeletePupilAsync(id);
        }
    }
}
