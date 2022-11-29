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
