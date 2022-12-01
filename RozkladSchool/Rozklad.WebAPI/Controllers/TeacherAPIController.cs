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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="teacherApiRepository"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacherDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Teacher> Create(TeacherCreateDto teacherDto)
        {
            var createdTeacher = await teacherApiRepository.AddTeacherByDtoAsync(teacherDto);
            return createdTeacher;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task Edit(TeacherCreateDto teacher)
        {
            await teacherApiRepository.UpdateTeacherAsync(teacher);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await teacherApiRepository.DeleteTeacherAsync(id);
        }
    }
}
