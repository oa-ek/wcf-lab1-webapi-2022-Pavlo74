using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.PupilDto
{
    public class PupilCreateDto
    {   
        public int PupilId { get; set; }
        public string? PupilName { get; set; }
    }
}
