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
            this.Property(c => c.IdAttendance).HasColumnName("ID_Attendance").IsRequired();
            this.Property(c => c.IdDentist).HasColumnName("ID_Dentist");
            this.Property(c => c.IdPatient).HasColumnName("ID_Patient");
            this.Property(c => c.DateTime).HasColumnName("DateTime_Attendance");
            this.Property(c => c.TimeSelect).HasColumnName("TimeSelect_Attendance");
            this.Property(c => c.TimeStart).HasColumnName("TimeStart_Attendance");
            this.Property(c => c.TimeFinish).HasColumnName("TimeFinish_Attendance");
            this.Property(c => c.Obs).HasColumnName("Obs_Attendance");
            this.Property(c => c.Status).HasColumnName("Status_Attendance");
        }
    }
}
