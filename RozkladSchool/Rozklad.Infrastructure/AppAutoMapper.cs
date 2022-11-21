using AutoMapper;
using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;

namespace Rozklad.Infrastructure
{
    public class AppAutoMapper : Profile
    {
       public AppAutoMapper()
        {
            CreateMap<CabinetReadDto, Cabinet>();
            CreateMap<Cabinet, CabinetReadDto>();
        }
           
    }
}