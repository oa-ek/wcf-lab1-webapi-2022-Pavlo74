using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.DisciplineDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class DisciplineRepository
    {

        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public DisciplineRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;

         }

        public async Task<IEnumerable<DisciplineReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<DisciplineReadDto>>(await _ctx.Disciplines.ToListAsync());
        }

        public async Task<DisciplineReadDto> GetAsync(int id)
        {
            return _mapper.Map<DisciplineReadDto>(await _ctx.Disciplines.FirstAsync(x => x.DisciplineId == id));
        }

        public async Task<Discipline> AddDisciplineByDtoAsync(DisciplineCreateDto disciplineDto)
        {
            var discipline = new Discipline();
            discipline.DisciplineName = disciplineDto.DisciplineName;
            
            _ctx.Disciplines.Add(discipline);
            await _ctx.SaveChangesAsync();
            return _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == discipline.DisciplineName);
        }

        public async Task UpdateDisciplineAsync(DisciplineCreateDto updatedDiscipline)
        {
            var discipline = _ctx.Disciplines.FirstOrDefault(x => x.DisciplineId == updatedDiscipline.DisciplineId);

            discipline.DisciplineName = updatedDiscipline.DisciplineName;
            await _ctx.SaveChangesAsync();
        }

        public async Task<Discipline> AddDisciplineAsync(Discipline discipline)
        {
            _ctx.Disciplines.Add(discipline);
            await _ctx.SaveChangesAsync();
            return _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == discipline.DisciplineName);
        }

        public List<Discipline> GetDisciplines()
        {
            var disciplineList = _ctx.Disciplines.ToList();
            return disciplineList;
        }

        public Discipline GetDiscipline(int id)
        {
            return _ctx.Disciplines.FirstOrDefault(x => x.DisciplineId == id);
        }

        public Discipline GetDisciplineByName(string name)
        {
            return _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == name);
        }

        public async Task DeleteDisciplineAsync(int id)
        {
            _ctx.Remove(GetDiscipline(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
