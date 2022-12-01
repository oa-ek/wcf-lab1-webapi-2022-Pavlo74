using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.TeacherDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAPIController : ControllerBase
    {
        private readonly TeacherRepository teacherApiRepository;
        private readonly ILogger<TeacherAPIController> _logger;
        public TeacherAPIController(ILogger<TeacherAPIController> logger, TeacherRepository teacherApiRepository)
        {
            _logger = logger;
            this.teacherApiRepository = teacherApiRepository;
        }
        [HttpGet]
        public TeacherRepository GetTeacherRepository()
        {
            return teacherApiRepository;
        }


        [HttpGet("Get_Teacher_List")]
        public async Task<IEnumerable<TeacherReadDto>> GetListAsync()
        {
            return await teacherApiRepository.GetListAsync();
        }

        [HttpPost]
        public async Task<Teacher> Create(TeacherCreateDto teacherDto)
        {
            var createdTeacher = await teacherApiRepository.AddTeacherByDtoAsync(teacherDto);
            return createdTeacher;
        }

        [HttpPut]
        public async Task Edit(TeacherCreateDto teacher)
        {
            await teacherApiRepository.UpdateTeacherAsync(teacher);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await teacherApiRepository.DeleteTeacherAsync(id);
        }
    }
}
