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
 public class CabinetRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public CabinetRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<CabinetReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<CabinetReadDto>>(await _ctx.Cabinets.ToListAsync());

        }

        public async Task<Cabinet> AddCabinetByDtoAsync(CabinetCreateDto cabDto)
        {
            var cab = new Cabinet();
            cab.CabinetName = cabDto.Name;
            cab.RoomCapacity = cabDto.RoomCapacity;
            _ctx.Cabinets.Add(cab);
            await _ctx.SaveChangesAsync();
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cab.CabinetName);
        }


        public async Task<Cabinet> AddCabinetAsync(Cabinet cabinet)
        {
            _ctx.Cabinets.Add(cabinet);
            await _ctx.SaveChangesAsync();
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinet.CabinetName);
        }

        public async Task<CabinetReadDto> GetAsync(int id)
        {
            return _mapper.Map<CabinetReadDto>(await _ctx.Cabinets.FirstAsync(x => x.CabinetId == id));
        }

        public async Task UpdateCabinetAsync(CabinetCreateDto updatedCabinet)
        {
            var cabinet = _ctx.Cabinets.FirstOrDefault(x => x.CabinetId == updatedCabinet.CabinetId);
            cabinet.RoomCapacity = updatedCabinet.RoomCapacity;
            cabinet.CabinetName = updatedCabinet.Name;
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteCabinetAsync(int id)
        {
            _ctx.Remove(GetCabinet(id));
            await _ctx.SaveChangesAsync();
        }

        public List<Cabinet> GetCabinets()
        {
            var cabinetList = _ctx.Cabinets.ToList();
            return cabinetList;
        }

        public Cabinet GetCabinet(int id)
        {
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetId == id);
        }

        public Cabinet GetCabinetByName(string name)
        {
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == name);
        }

       

    }
}
