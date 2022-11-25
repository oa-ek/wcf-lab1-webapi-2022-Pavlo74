using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using Rozklad.Repository.Dto.CabinetDto;


namespace RozkladSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetAPIController : ControllerBase
    {

        private readonly CabinetAPIRepository cabinetApiRepository;
        public CabinetAPIController(CabinetAPIRepository cabinetApiRepository)
        {

            this.cabinetApiRepository = cabinetApiRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return await cabinetApiRepository.GetListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CabinetName"></param>
        /// <returns></returns>
        //[HttpGet("{CabinetName}")]
        //public async Task<IEnumerable<CabinetReadDto>> GetItemAsync(string CabinetName)
        //{
        //return await cabinetApiRepository.GetItemAsync(CabinetName);
        // }

        //[HttpPost]
        //public async Task<int> Create(CabinetReadDto obj)
        //{
        // return obj.CabinetId * 3;
        //}
    }

}
