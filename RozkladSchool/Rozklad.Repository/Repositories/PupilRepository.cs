using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.PupilDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class PupilRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public PupilRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public async Task<Pupil> AddPupilAsync(Pupil pupil)
        {
            _ctx.Pupils.Add(pupil);
            await _ctx.SaveChangesAsync();
            return _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupil.PupilName);
        }

        public async Task<IEnumerable<PupilReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<PupilReadDto>>(await _ctx.Pupils.ToListAsync());

        }

        public async Task<PupilReadDto> GetAsync(int id)
        {
            return _mapper.Map<PupilReadDto>(await _ctx.Pupils.FirstAsync(x => x.PupilId == id));
        }

        public async Task<Pupil> AddPupilByDtoAsync(PupilCreateDto pupilDto)
        {
            var pupil = new Pupil();
            pupil.PupilName = pupilDto.PupilName;

            _ctx.Pupils.Add(pupil);
            await _ctx.SaveChangesAsync();
            return _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupil.PupilName);
        }

        public async Task UpdatePupilAsync(PupilCreateDto updatedPupil)
        {
            var pupil = _ctx.Pupils.FirstOrDefault(x => x.PupilId == updatedPupil.PupilId);

            pupil.PupilName = updatedPupil.PupilName;
            await _ctx.SaveChangesAsync();
        }

        public Pupil GetPupil(int id)
        {
            return _ctx.Pupils.Include(x => x.ClassRoom).FirstOrDefault(x => x.PupilId == id);
        }

        public Pupil GetPupilByName(string name)
        {
            return _ctx.Pupils.Include(x => x.ClassRoom).FirstOrDefault(x => x.PupilName == name);
        }

        public List<Pupil> GetPupils()
        {
            var pupilList = _ctx.Pupils.ToList(); 
            return pupilList;
        }

        public async Task DeletePupilAsync(int id)
        {
            _ctx.Remove(GetPupil(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
