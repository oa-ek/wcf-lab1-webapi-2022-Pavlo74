using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.ClassDto;
using Rozklad.Repository.Repositories;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomAPIController : ControllerBase
    {
        private readonly ClassRoomRepository classRoomApiRepository;
        private readonly ILogger<ClassRoomAPIController> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="classRoomApiRepository"></param>
        public ClassRoomAPIController(ILogger<ClassRoomAPIController> logger, ClassRoomRepository classRoomApiRepository)
        {
            _logger = logger;
            this.classRoomApiRepository = classRoomApiRepository;
        }
        
        [HttpGet]
        public ClassRoomRepository GetClassRoomRepository()
        {
            return classRoomApiRepository;
        }

        [HttpGet("Get_ClassRoom_List")]
        public async Task<IEnumerable<ClassRoomReadDto>> GetListAsync()
        {
            return await classRoomApiRepository.GetListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="classDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ClassRoom> Create(ClassCreateDto classDto)
        {
            var createdClassRoom = await classRoomApiRepository.AddClassRoomByDtoAsync(classDto);
            return createdClassRoom;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="classRoom"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task Edit(ClassCreateDto classRoom)
        {
            await classRoomApiRepository.UpdateClassRoomAsync(classRoom);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await classRoomApiRepository.DeleteClassAsync(id);
        }
    }
}
