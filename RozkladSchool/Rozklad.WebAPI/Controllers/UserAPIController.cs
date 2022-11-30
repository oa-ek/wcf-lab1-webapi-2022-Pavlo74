using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository;
using Rozklad.Repository.Dto;

namespace Rozklad.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly UsersRepository userApiRepository;
        private readonly ILogger<UserAPIController> _logger;
        public UserAPIController(ILogger<UserAPIController> logger, UsersRepository userApiRepository)
        {
            _logger = logger;
            this.userApiRepository = userApiRepository;
        }
        [HttpGet]
        public UsersRepository GetUserRepository()
        {
            return userApiRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserListAsync")]
        public async Task<IEnumerable<UserReadDto>> GetListAsync()
        {
            return await userApiRepository.GetListAsync();
        }
    }
}
