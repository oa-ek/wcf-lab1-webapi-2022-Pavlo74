using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        //private readonly ClassRoomRepository classRoomRepository;
        private readonly CabinetRepository cabinetRepository;
        private readonly ClassRoomRepository classRoomRepository;
        private readonly DisciplineRepository disciplineRepository;
        private readonly TeacherRepository teacherRepository;
        private readonly WeekRepository weekRepository;
        private readonly PupilRepository pupilRepository;
        private readonly LessonRepository lessonRepository;
        //private readonly UsersRepository usersRepository;
        //private readonly UserManager<User> userManager;
       // private readonly SignInManager<User> signInManager;
        private readonly ILogger<TimetableController> _logger;
        // private readonly TimetableRepository ctx;
        private readonly TimetableRepository timetableRepository;
        //private readonly CabinetRepository cabinetsRepository;
        public TimetableController(TimetableRepository timetableRepository, ClassRoomRepository classRoomRepository, CabinetRepository cabinetRepository, DisciplineRepository disciplineRepository, TeacherRepository teacherRepository, WeekRepository weekRepository, PupilRepository pupilRepository, LessonRepository lessonRepository, ILogger<TimetableController> logger)
        {
            this.timetableRepository = timetableRepository;

            _logger = logger;

            this.classRoomRepository = classRoomRepository;
            this.cabinetRepository = cabinetRepository;
            this.weekRepository = weekRepository;
            this.disciplineRepository = disciplineRepository;
            this.teacherRepository = teacherRepository;
            this.pupilRepository = pupilRepository;
            this.lessonRepository = lessonRepository;
            //this.usersRepository = usersRepository;
           // this.userManager = userManager;
            //this.signInManager = signInManager;

        }



        [HttpGet("/timetable")]
        public async Task<IActionResult> GetListAsync()
        {
            return Ok(await timetableRepository.GetListAsync());
        }

        [HttpGet("{id}")]
        public async Task<TimetableReadDto> GetById(int id)
        {
            return await timetableRepository.GetAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await timetableRepository.DeleteTimetableAsync(id);
        }

        [HttpGet("search/{searchText}")]
        public ActionResult<List<TimetableCreateDto>> SearchTimetables(string searchText)
        {
            return Ok(timetableRepository.SearchTimetable(searchText));
        }

        [HttpPost]
        public async Task<TimetableCreateDto> CreateAsync(Timetable timetable)
        {
         return await timetableRepository.AddTimetableAsync(timetable);
        }
        /*public async Task CreateKey(TimetableCreateDto timetableCreateDto, string cabinets, string lessons, string weeks, string users, string disciplines, string pupils, string teachers)
        {
            var cabinet = cabinetRepository.GetCabinetByName(cabinets);
            if (cabinet == null)
            {
                cabinet = new Cabinet() { CabinetName = cabinets };
                cabinet = await cabinetRepository.AddCabinetAsync(cabinet);
            }

            var lesson = lessonRepository.GetLessonByName(lessons);
            if (lesson == null)
            {
                lesson = new Lesson() { LessonName = lessons };
                lesson = await lessonRepository.AddLessonAsync(lesson);
            }

            var week = weekRepository.GetWeekByName(weeks);
            if (week == null)
            {
                week = new Week() { WeekName = weeks };
                week = await weekRepository.AddWeekAsync(week);
            }

            var discipline = disciplineRepository.GetDisciplineByName(disciplines);
            if (discipline == null)
            {
                discipline = new Discipline() { DisciplineName = disciplines };
                discipline = await disciplineRepository.AddDisciplineAsync(discipline);
            }

            var pupil = pupilRepository.GetPupilByName(pupils);
            if (pupil == null)
            {
                pupil = new Pupil() { PupilName = pupils };
                pupil = await pupilRepository.AddPupilAsync(pupil);
            }

            var teacher = teacherRepository.GetTeacherByName(teachers);
            if (teacher == null)
            {
                teacher = new Teacher() { TeacherName = teachers };
                teacher = await teacherRepository.AddTeacherAsync(teacher);
            }


            var user = usersRepository.GetUserByEmail(User.Identity.Name);
            if (user == null)
            {
                user = new User() { Email = User.Identity.Name };
            }

            var key = await timetableRepository.AddTimetableAsync(new Timetable()
            {
                LessonNumber = timetableCreateDto.LessonNumber,
                Day = timetableCreateDto.Day,
                TimeStart = timetableCreateDto.TimeStart,
                TimeEnd = timetableCreateDto.TimeEnd,
              
                Cabinet = cabinet,
                Lesson = lesson,
                Week = week,
                
                //Discipline = discipline,
            });
        }*/

    }
}

