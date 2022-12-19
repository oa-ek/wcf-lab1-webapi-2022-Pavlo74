using Rozklad.Core;
using Rozklad.Repository.Dto;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Dto.TimetableDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RozkladClient.Infrastructure
{
    public class HttpTimetableService : HttpBaseService
    {
        public HttpTimetableService(HttpClient httpClient)
           : base(httpClient) { }

        public async Task<IEnumerable<TimetableReadDto>> GetTimetablesAsync()
        {
           return await httpClient.GetFromJsonAsync<IEnumerable<TimetableReadDto>>("/timetables");
        }

        public async Task<IEnumerable<CabinetReadDto>> GetCabinetsAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<CabinetReadDto>>("/cabinets");
        }

        public async Task<IEnumerable<LessonReadDto>> GetLessonsAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<LessonReadDto>>("/lessons");
        }

        public async Task<IEnumerable<WeekReadDto>> GetWeeksAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<WeekReadDto>>("/weeks");
        }

        public async Task<TimetableReadDto> GetAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<TimetableReadDto>($"/api/timetables/{id}");
        }
    }
}
