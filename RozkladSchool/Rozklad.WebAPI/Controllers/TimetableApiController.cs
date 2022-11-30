using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TimetableAPIController : ControllerBase
    {
        private readonly TimetableRepository timetableRepository;
        public TimetableAPIController(TimetableRepository timetableRepository)
        {
            this.timetableRepository = timetableRepository;
            
        }

        [HttpGet]
        public TimetableRepository GetTimetableRepository()
        {
            return timetableRepository;
        }
        [HttpGet("gettimetables")]
        public List<Timetable> GetTimetablesAPI()
        {
            var timetables = timetableRepository.GetTimetables();
            return timetables;
        }
    }
}
