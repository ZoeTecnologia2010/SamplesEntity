using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Attendance
    {
        public int IdAttendance { get; set; }
        public int IdDentist { get; set; }
        public int IdPatient { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? TimeSelect { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeFinish { get; set; }
        public string Obs { get; set; }
        public string Status { get; set; }
    }
}
