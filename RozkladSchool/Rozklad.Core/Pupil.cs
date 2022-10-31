﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Pupil
    {
        [Key]
        public int PupilId { get; set; }
        public string? PupilName { get; set; }
        public virtual ICollection<ClassRoom> ClassRooms { get; set; }
    }
}
