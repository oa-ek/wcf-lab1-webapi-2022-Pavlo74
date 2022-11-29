using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class CabinetAPIRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;

        public CabinetAPIRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<CabinetReadDto>>(await _ctx.Cabinets.ToListAsync());

        }

        public Cabinet GetCabinetByName(string name)
        {
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == name);
        }

        public async Task<Cabinet> AddCabinetAsync(Cabinet cabinet)
        {
            _ctx.Cabinets.Add(cabinet);
            await _ctx.SaveChangesAsync();
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinet.CabinetName);
        }
        //public async Task<IEnumerable<CabinetReadDto>> GetItemAsync(string name)
        //{
        // return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == name);
        //}
    }
}
