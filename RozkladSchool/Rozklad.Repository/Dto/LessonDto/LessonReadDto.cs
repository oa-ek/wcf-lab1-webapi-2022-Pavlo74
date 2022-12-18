using Rozklad.Core;
using Rozklad.Repository.Dto.DisciplineDto;
using Rozklad.Repository.Dto.PupilDto;
using Rozklad.Repository.Dto.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.LessonDto
{
    public class LessonReadDto
    {
        public int LessonId { get; set; }
        public string? LessonName { get; set; }
        public int Year { get; set; }
        public int DisciplineId { get; set; }
        public DisciplineReadDto? Discipline { get; set; }
        
        public int TeacherId { get; set; }
        public TeacherReadDto? Teacher { get; set; }

        public int PupilId { get; set; }
        public PupilReadDto? Pupil { get; set; }

        //public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
