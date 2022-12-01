using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.ClassDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class ClassRoomRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IMapper _mapper;
        public ClassRoomRepository(RozkladContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClassRoomReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<ClassRoomReadDto>>(await _ctx.ClassRooms.ToListAsync());
        }

        public async Task<ClassRoomReadDto> GetAsync(int id)
        {
            return _mapper.Map<ClassRoomReadDto>(await _ctx.ClassRooms.FirstAsync(x => x.ClassRoomId == id));
        }

        public async Task<ClassRoom> AddClassRoomByDtoAsync(ClassCreateDto classDto)
        {
            var classRoom = new ClassRoom();
            classRoom.ClassRoomName = classDto.ClassRoomName;
            classRoom.Year = classDto.Year;
            _ctx.ClassRooms.Add(classRoom);
            await _ctx.SaveChangesAsync();
            return _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomName == classRoom.ClassRoomName);
        }

        public async Task UpdateClassRoomAsync(ClassCreateDto updatedClassRoom)
        {
            var classRoom = _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomId == updatedClassRoom.ClassRoomId);

            classRoom.ClassRoomName = updatedClassRoom.ClassRoomName;
            classRoom.Year = updatedClassRoom.Year;
            await _ctx.SaveChangesAsync();
        }

        public async Task<ClassRoom> AddClassAsync(ClassRoom clas)
        {
            _ctx.ClassRooms.Add(clas);
            await _ctx.SaveChangesAsync();
            return _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomName == clas.ClassRoomName);
        }



        public ClassRoom GetClass(int id)
        {
            return _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomId == id);
        }

        public List<ClassRoom> GetClasses()
        {
            var clasList = _ctx.ClassRooms.ToList();
            return clasList;
        }

        public ClassRoom GetClassByName(string name)
        {
            return _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomName == name);
        }

        public async Task DeleteClassAsync(int id)
        {
            _ctx.Remove(GetClass(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
