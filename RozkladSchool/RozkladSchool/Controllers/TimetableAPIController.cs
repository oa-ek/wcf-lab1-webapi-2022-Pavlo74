using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;

namespace RozkladSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableAPIController : ControllerBase
    {
        private readonly ILogger<TimetableAPIController> _logger;
        private readonly TimetableAPIRepository _timetableAPIRepository;
        private readonly LessonAPIRepository _lessonAPIRepository;
        private readonly CabinetAPIRepository _cabinetAPIRepository;
        private readonly UsersAPIRepository _usersAPIRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TimetableAPIRepository timetableApiRepository;
        public TimetableAPIController(ILogger<TimetableAPIController> logger, UserManager<User> userManager, CabinetAPIRepository cabinetAPIRepository, SignInManager<User> signInManager, TimetableAPIRepository timetableApiRepository, LessonAPIRepository lessonAPIRepository, UsersAPIRepository usersAPIRepository)
        {
            
            this.timetableApiRepository = timetableApiRepository;
            _logger = logger;
            _timetableAPIRepository = timetableApiRepository;
            _lessonAPIRepository = lessonAPIRepository;
            _cabinetAPIRepository = cabinetAPIRepository;
            _usersAPIRepository = usersAPIRepository;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpGet]
        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return await timetableApiRepository.GetListAsync();
        }

        //[HttpPost]
        
        //public async Task<TimetableCreateDto> AddRozklad(TimetableCreateDto timetableDto, string cabinetName)
        //{
           
            
        //}


    }
}
