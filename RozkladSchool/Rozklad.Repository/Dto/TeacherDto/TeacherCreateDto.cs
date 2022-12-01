using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.TeacherDto
{
    public class TeacherCreateDto
    {
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
    }
}
