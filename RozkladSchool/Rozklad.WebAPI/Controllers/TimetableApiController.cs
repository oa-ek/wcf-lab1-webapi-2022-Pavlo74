using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TimetableAPIController : ControllerBase
    {
        
        private readonly ILogger<TimetableAPIController> _logger;
        private readonly TimetableRepository timetableRepository;
        private readonly ClassRoomRepository classRoomRepository;
        private readonly CabinetRepository cabinetRepository;
        private readonly DisciplineRepository disciplineRepository;
        private readonly TeacherRepository teacherRepository;
        private readonly WeekRepository weekRepository;
        private readonly PupilRepository pupilRepository;
        private readonly LessonRepository lessonRepository;
        private readonly UsersRepository usersRepository;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public TimetableAPIController(TimetableRepository timetableRepository, ClassRoomRepository classRoomRepository)
        {
            this.timetableRepository = timetableRepository;
            
        }

        [HttpGet]
        public TimetableRepository GetTimetableRepository()
        {
            return timetableRepository;
        }
        [HttpGet("getTimetables")]
        public List<Timetable> GetTimetablesAPI()
        {
            var timetables = timetableRepository.GetTimetables();
            return timetables;
        }
    }
}
