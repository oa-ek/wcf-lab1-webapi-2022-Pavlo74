using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class UsersAPIRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;

        public UsersAPIRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<UserReadDto>>(await _ctx.Users.ToListAsync());

        }
    }
}
