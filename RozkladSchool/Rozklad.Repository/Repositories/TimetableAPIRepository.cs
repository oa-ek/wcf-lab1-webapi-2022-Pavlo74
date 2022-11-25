using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class TimetableAPIRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;

        public TimetableAPIRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TimetableReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<TimetableReadDto>>(await _ctx.Timetables.ToListAsync());

        }
    }
}
