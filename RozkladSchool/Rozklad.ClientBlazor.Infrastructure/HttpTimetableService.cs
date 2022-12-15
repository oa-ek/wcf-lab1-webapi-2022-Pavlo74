using Rozklad.Repository.Dto.TimetableDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.ClientBlazor.Infrastructure
{
    public class HttpTimetableService : HttpBaseService
    {
        public HttpTimetableService(HttpClient httpClient)
          : base(httpClient) { }

        public async Task<IEnumerable<TimetableReadDto>> GetTimetableAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<TimetableReadDto>>("/api/timetables");
        }

        public async Task<int> CreateRequestsAsync(TimetableCreateDto time)
        {
            var msg = await httpClient.PostAsJsonAsync<TimetableCreateDto>("/api/timetables", time);
            return int.Parse(await msg.Content.ReadAsStringAsync());
        }

        public async Task<TimetableReadDto> GetAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<TimetableReadDto>($"/api/timetables/{id}");
        }
    }
}
