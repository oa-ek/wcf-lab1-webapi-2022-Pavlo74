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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="pupilApiRepository"></param>
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

        [HttpGet("Get_Pupil_List")]
        public async Task<IEnumerable<PupilReadDto>> GetListAsync()
        {
            return await pupilApiRepository.GetListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pupilDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Pupil> Create(PupilCreateDto pupilDto)
        {
            var createdPupil = await pupilApiRepository.AddPupilByDtoAsync(pupilDto);
            return createdPupil;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pupil"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task Edit(PupilCreateDto pupil)
        {
            await pupilApiRepository.UpdatePupilAsync(pupil);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await pupilApiRepository.DeletePupilAsync(id);
        }
    }
}
