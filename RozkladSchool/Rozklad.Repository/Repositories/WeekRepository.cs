using Rozklad.Core;
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
        public WeekRepository(RozkladContext ctx)
        {
            _ctx = ctx;
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
