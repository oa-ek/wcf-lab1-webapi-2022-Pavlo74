
using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using Rozklad.Repository.Dto.DisciplineDto;
using Rozklad.Repository.Dto.LessonDto;
using Rozklad.Repository.Dto.PupilDto;
using Rozklad.Repository.Dto.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.TimetableDto
{
    public class TimetableReadDto
    {
        public int TimetableId { get; set; }

        public int LessonNumber { get; set; }

        public string? Day { get; set; }

        public string? TimeStart { get; set; }

        public string? TimeEnd { get; set; }

        //public string? IconPath { get; set; }
        //public int CabinetId { get; set; }
        //public string? CabinetName { get; set; }
        public CabinetReadDto Cabinet { get; set; }
        //public int WeekId;

        public LessonReadDto? Lesson { get; set; }
        //public string? WeekName { get; set; }

        //public WeekReadDto? Week { get; set; }
        //public PupilReadDto Pupil { get; set; }
        //public UserReadDto? User { get; set; }
        //public string? DisciplineName { get; set; }
        //public DisciplineReadDto Discipline { get; set; }
         //public string? TeacherName { get; set; }
         //public TeacherReadDto? Teacher { get; set; }
        // public string? PupilName { get; set; }

        // public string? ClassRoomName { get; set; }

        //public int LessonId { get; set; }
        //public string? LessonName { get; set; }

         //public string? UserId { get; set; }
       

    }
}
