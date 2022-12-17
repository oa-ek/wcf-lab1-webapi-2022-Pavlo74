using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;


namespace Rozklad.Repository.Repositories
{
    public class TimetableRepository
    {
        private readonly RozkladContext _ctx;
        //private readonly UsersRepository _usersRepository;
        private readonly IMapper _mapper;
        public TimetableRepository(RozkladContext ctx, /*UsersRepository usersRepository,*/ IMapper mapper)
        {
            _ctx = ctx;
            //_usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<TimetableReadDto>>(await _ctx.Timetables.Include(x => x.Cabinet).Include(x => x.Lesson).ThenInclude(x => x.Discipline)/*.Include(x => x.Lesson.Teacher).Include(x => x.Lesson.Pupil).ThenInclude(x => x.ClassRoom)*/.Include(x => x.Week).ToListAsync());

        }

        public async Task<TimetableReadDto> GetAsync(int id)
        {
            return _mapper.Map<TimetableReadDto>(await _ctx.Timetables.Include(x => x.Cabinet).Include(x => x.Lesson)/*ThenInclude(x => x.Discipline)/*Include(x => x.Lesson.Teacher).Include(x => x.Lesson.Pupil).ThenInclude(x => x.ClassRoom)/*.Include(x => x.Week).Include(x => x.User)*/.FirstAsync());
        }

        public async Task<TimetableCreateDto> AddTimetableAsync(Timetable timetable)
        {
            _ctx.Timetables.Add(timetable);
            await _ctx.SaveChangesAsync();
            var createdTimetable = _ctx.Timetables.Include(x => x.Cabinet).Include(x => x.Lesson).Include(x => x.Week).FirstOrDefault(x => x.TimetableId == timetable.TimetableId);
            return new TimetableCreateDto
            {
                TimetableId = createdTimetable.TimetableId,
                TimeStart = createdTimetable.TimeStart,
                TimeEnd = createdTimetable.TimeEnd,
                LessonNumber = createdTimetable.LessonNumber,
                
                CabinetName = createdTimetable.Cabinet.CabinetName,
                LessonName = createdTimetable.Lesson.LessonName, 
                WeekName = createdTimetable.Week.WeekName
            };
        }

        public Timetable GetTimetable(int id)
        {
            return _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).
               Include(x => x.Lesson).
               ThenInclude(x => x.Discipline).
               Include(x => x.Lesson).
               ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.Week).
               Include(x => x.Lesson).
               ThenInclude(x => x.Pupil).
               ThenInclude(x => x.ClassRoom).
               Include(x => x.User).

               FirstOrDefault();
        }

        public List<Timetable> GetTimetables()
        {
            var timetableList = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.Week).
               Include(x => x.User).ToList();

            return timetableList;
        }

        public List<TimetableCreateDto> GetTimetablesDto()
        {
            var timetableList = _ctx.Timetables.Include(x => x.Cabinet).Include(x => x.Week).Include(x => x.User).ToList();
            var timetableListDto = new List<TimetableCreateDto>();
            foreach (var timetable in timetableList)
            {
                timetableListDto.Add(new TimetableCreateDto
                {
                    TimetableId = timetable.TimetableId,
                    LessonNumber = timetable.LessonNumber,
                    TimeStart = timetable.TimeStart,
                    CabinetName = timetable.Cabinet.CabinetName,
                    WeekName = timetable.Week.WeekName,
                    
                });
            }
            return timetableListDto;
        }


        public List<Timetable> GetTimetablesAPI()
        {
            var timetableList = _ctx.Timetables.Include(x => x.Cabinet)/*.Include(x => x.User).*/.ToList();

            return timetableList;
        }

        public async Task<TimetableReadDto> GetTimetableDto(int id)
        {
            var v = await _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.Week).
               Include(x => x.User).FirstAsync(x => x.TimetableId == id);

            var timetableDto = new TimetableReadDto
            {
                TimetableId = v.TimetableId,
                LessonNumber = v.LessonNumber,
                Day = v.Day,
                TimeStart = v.TimeStart,
                TimeEnd = v.TimeEnd,
                //DisciplineName = v.Lesson.Discipline.DisciplineName,
                //PupilName = v.Lesson.Pupil.PupilName,
                //TeacherName = v.Lesson.Teacher.TeacherName,
                //LessonName = v.Lesson?.LessonName,
                //CabinetName = v.Cabinet?.CabinetName,
                //WeekName = v.Week?.WeekName,
                //UserId = v.UserId
            };
            return timetableDto;
        }

      

        public async Task UpdateAsync(TimetableReadDto timetableDto, string cabinetName, string disciplineName,
           string classRoomName, string teacherName, string pupilName, string weekName)
        {
            var timetable = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
                 Include(x => x.Cabinet).
                 Include(x => x.Week).
                 Include(x => x.User).FirstOrDefault(x => x.TimetableId == timetableDto.TimetableId);

            if (timetable.Cabinet.CabinetName != cabinetName)
                timetable.Cabinet = _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinetName);

            if (timetable.Week.WeekName != weekName)
                timetable.Week = _ctx.Weeks.FirstOrDefault(x => x.WeekName == weekName);

            if (timetable.Lesson.Teacher.TeacherName != teacherName)
                timetable.Lesson.Teacher = _ctx.Teachers.FirstOrDefault(x => x.TeacherName == teacherName);

            if (timetable.Lesson.Discipline.DisciplineName != disciplineName)
                timetable.Lesson.Discipline = _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == disciplineName);

            if (timetable.Lesson.Pupil.PupilName != pupilName)
                timetable.Lesson.Pupil = _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupilName);

            //if (timetable.Lesson.Pupil.ClassRoom.ClassRoomName != classRoomName)
                //timetable.Lesson.Pupil.ClassRoom = _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomName == classRoomName);

            if (timetable.Day != timetableDto.Day)
                timetable.Day = timetableDto.Day;

            if (timetable.LessonNumber != timetableDto.LessonNumber)
                timetable.LessonNumber = timetableDto.LessonNumber;

            if (timetable.TimeStart != timetableDto.TimeStart)
                timetable.TimeStart = timetableDto.TimeStart;

            if (timetable.TimeEnd != timetableDto.TimeEnd)
                timetable.TimeEnd = timetableDto.TimeEnd;

             _ctx.SaveChanges();
        }

        public async Task DeleteTimetableAsync(int id)
        {
            _ctx.Remove(GetTimetable(id));
            await _ctx.SaveChangesAsync();
        }

        public List<TimetableCreateDto> SearchTimetable(string searchText)
        {
            return GetTimetablesDto().
                Where(x => x.LessonNumber.ToString().Contains(searchText.ToLower()) || x.TimeStart.ToLower().Contains(searchText.ToLower()) || x.TimeEnd.ToString().Contains(searchText.ToLower())).ToList();
        }
    }
}

