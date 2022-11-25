using AutoMapper;
using Rozklad.Core;
using Rozklad.Repository.Dto;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Dto.DisciplineDto;
using Rozklad.Repository.Dto.LessonDto;
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

            CreateMap<UserReadDto, User>();
            CreateMap<User, UserReadDto>();

            CreateMap<LessonReadDto, Lesson>();
            CreateMap<Lesson, LessonReadDto>();

            CreateMap<TeacherReadDto, Teacher>();
            CreateMap<Teacher, TeacherReadDto>();

            CreateMap<DisciplineReadDto, Discipline>();
            CreateMap<Discipline, DisciplineReadDto>();

            CreateMap<TimetableReadDto, Timetable>();
            CreateMap<Timetable, TimetableReadDto>();
        }
           
    }
}