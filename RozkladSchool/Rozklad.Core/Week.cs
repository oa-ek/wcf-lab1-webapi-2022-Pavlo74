using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Week
    {
        [Key]
        public int WeekId { get; set; }
        public string? WeekName { get; set; }
        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
