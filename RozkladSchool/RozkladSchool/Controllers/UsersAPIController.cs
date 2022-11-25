using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Dto;
using Rozklad.Repository.Repositories;

namespace RozkladSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersAPIController : ControllerBase
    {
        private readonly UsersAPIRepository usersApiRepository;
        public UsersAPIController(UsersAPIRepository usersApiRepository)
        {

            this.usersApiRepository = usersApiRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<UserReadDto>> GetListAsync()
        {
            return await usersApiRepository.GetListAsync();
        }
    }
}
