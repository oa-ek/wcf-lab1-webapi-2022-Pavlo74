using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.ClassDto
{
    public class ClassCreateDto
    {
        public int ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
    }
}
