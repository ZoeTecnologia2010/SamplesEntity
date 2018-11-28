using Controllers.Map;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Context
{
    class SystemContext : DbContext
    {
        public SystemContext() : base("Server=ZoeVM; Database=Samples;Integrated Security=True;")
        {

        }
              
        public DbSet<Attendance> Attendances{ get; set;}
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Dentist> Dentists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SystemContext>(null);
            modelBuilder.Configurations.Add(new DentistMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new AttendanceMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
