using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Dto.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
   public class TeacherRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public TeacherRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;

         }

        public async Task<IEnumerable<TeacherReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<TeacherReadDto>>(await _ctx.Teachers.ToListAsync());
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            _ctx.Teachers.Add(teacher);
            await _ctx.SaveChangesAsync();
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherName == teacher.TeacherName);
        }

        public List<Teacher> GetTeachers()
        {
            var teacherList = _ctx.Teachers.ToList();
            return teacherList;
        }

        public Teacher GetTeacher(int id)
        {
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherId == id);
        }

        public Teacher GetTeacherByName(string name)
        {
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherName == name);
        }

        public async Task DeleteTeacherAsync(int id)
        {
            _ctx.Remove(GetTeacher(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
