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
    public class WeekRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public WeekRepository(RozkladContext ctx, IMapper mapper)
        {
            _mapper = mapper;
            _ctx = ctx;
        }

        public async Task<IEnumerable<WeekReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<WeekReadDto>>(await _ctx.Weeks.ToListAsync());

        }

        public async Task<WeekReadDto> GetAsync(int id)
        {
            return _mapper.Map<WeekReadDto>(await _ctx.Weeks.FirstAsync(x => x.WeekId == id));
        }

        public async Task<Week> AddWeekByDtoAsync(WeekCreateDto weekDto)
        {
            var week = new Week();
            week.WeekName = weekDto.WeekName;

            _ctx.Weeks.Add(week);
            await _ctx.SaveChangesAsync();
            return _ctx.Weeks.FirstOrDefault(x => x.WeekName == week.WeekName);
        }

        public async Task UpdateWeekAsync(WeekCreateDto updatedWeek)
        {
            var week = _ctx.Weeks.FirstOrDefault(x => x.WeekId == updatedWeek.WeekId);
            week.WeekName = updatedWeek.WeekName;
            await _ctx.SaveChangesAsync();
        }

        public async Task<Week> AddWeekAsync(Week week)
        {
            _ctx.Weeks.Add(week);
            await _ctx.SaveChangesAsync();
            return _ctx.Weeks.FirstOrDefault(x => x.WeekName == week.WeekName);
        }

        public List<Week> GetWeeks()
        {
            var weekList = _ctx.Weeks.ToList();
            return weekList;
        }

        public Week GetWeek(int id)
        {
            return _ctx.Weeks.FirstOrDefault(x => x.WeekId == id);
        }

        public Week GetWeekByName(string name)
        {
            return _ctx.Weeks.FirstOrDefault(x => x.WeekName == name);
        }

        public async Task DeleteWeekAsync(int id)
        {
            _ctx.Remove(GetWeek(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
