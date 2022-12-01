using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.DisciplineDto
{
    public class DisciplineCreateDto
    {
        public int DisciplineId { get; set; }
        public string? DisciplineName { get; set; }
    }
}
