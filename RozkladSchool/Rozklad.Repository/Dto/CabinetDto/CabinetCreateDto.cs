using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.CabinetDto
{
    public class CabinetCreateDto
    {
       
        public int CabinetId { get; set; }
        public string? Name { get; set; }
        public int RoomCapacity { get; set; }

    }
}
