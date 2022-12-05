using AutoMapper;
using Rozklad.Core;
using Rozklad.Repository.Dto;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Dto.ClassDto;
using Rozklad.Repository.Dto.DisciplineDto;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Dto.PupilDto;
using Rozklad.Repository.Dto.TeacherDto;
using Rozklad.Repository.Dto.TimetableDto;

namespace Rozklad.Infrastructure
{
    public class AppAutoMapper : Profile
    {
        
       public AppAutoMapper()
        {
            CreateMap<CabinetReadDto, Cabinet>();
            CreateMap<Cabinet, CabinetReadDto>();

            CreateMap<CabinetCreateDto, Cabinet>();
            CreateMap<Cabinet, CabinetCreateDto>();

            CreateMap<ClassRoomReadDto, ClassRoom>();
            CreateMap<ClassRoom, ClassRoomReadDto>();

            CreateMap<UserReadDto, User>();
            CreateMap<User, UserReadDto>();

            CreateMap<PupilReadDto, Pupil>();
            CreateMap<Pupil, PupilReadDto>();

            CreateMap<LessonReadDto, Lesson>();
            CreateMap<Lesson, LessonReadDto>();

            CreateMap<TeacherReadDto, Teacher>();
            CreateMap<Teacher, TeacherReadDto>();

            CreateMap<DisciplineReadDto, Discipline>();
            CreateMap<Discipline, DisciplineReadDto>();

            CreateMap<TimetableReadDto, Timetable>();
            CreateMap<Timetable, TimetableReadDto>();

            //CreateMap<WeekReadDto, Timetable>();
            //CreateMap<Timetable, TimetableReadDto>();

            //CreateMap<TimetableCreateDto, Timetable>();
            //CreateMap<Timetable, TimetableCreateDto>();
        }
           
    }
}