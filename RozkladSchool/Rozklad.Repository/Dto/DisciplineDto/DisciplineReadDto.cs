﻿using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.DisciplineDto
{
    public class DisciplineReadDto
    {

        public int DisciplineId { get; set; }
        public string? DisciplineName { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Timetable>? Timetables { get; set; }
    }
}
