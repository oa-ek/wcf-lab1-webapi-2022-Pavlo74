using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TimetableAPIController : ControllerBase
    {
       
        private readonly ILogger<TimetableAPIController> _logger;
       // private readonly TimetableRepository ctx;
        private readonly TimetableRepository timetableRepository;
        //private readonly CabinetRepository cabinetsRepository;
        public TimetableAPIController(TimetableRepository timetableRepository, /*CabinetRepository cabinetRepository,*/ ILogger<TimetableAPIController> logger )
        {
            this.timetableRepository = timetableRepository;
            //cabinetsRepository = cabinetRepository;
            _logger = logger;
           // ctx = context;

        }

        [HttpGet]
        public TimetableRepository GetTimetableRepository()
        {
            return timetableRepository;
        }

        //[HttpGet]

        //public TimetableRepository GetTimetableRepository()
        //{
        //return timetableRepository;
        //}

        [HttpGet("Get-timetable")]
        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return await timetableRepository.GetListAsync();
        }
        //[HttpGet("get-Timetables")]

        //public List<Timetable> GetTimetablesAPI()
        //{
        //var timetables = timetableRepository.GetTimetables();
        //return timetables;
        //}
    }
}
