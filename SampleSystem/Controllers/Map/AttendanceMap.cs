using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class AttendanceMap : EntityTypeConfiguration<Attendance>
    {
        public AttendanceMap()
        {
            this.ToTable("Attendance");
            this.HasKey(c => c.IdAttendance);
            this.Property(c => c.IdAttendance).HasColumnName("ID_ATTENDANCE").IsRequired();
            this.Property(c => c.IdDentist).HasColumnName("ID_DENTIST");
            this.Property(c => c.IdPacient).HasColumnName("ID_PACIENT");
            this.Property(c => c.Date).HasColumnName("DATE_ATTENDANCE");
            this.Property(c => c.TimeSelect).HasColumnName("TIMESELECT_ATTENDANCE");
            this.Property(c => c.TimeStart).HasColumnName("TIMESTART_ATTENDANCE");
            this.Property(c => c.TimeFinish).HasColumnName("TIMEFINISH_ATTENDANCE");
            this.Property(c => c.Obs).HasColumnName("OBS_ATTENDANCE");
            this.Property(c => c.Status).HasColumnName("STATUS_ATTENDANCE");
        }
    }
}
