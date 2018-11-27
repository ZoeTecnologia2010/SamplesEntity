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
        //public SistemaContext() : base("Server=DESKTOP-THHNDIF\\SQLEXPRESS; Database=odonto;Integrated Security=True;")
        public SystemContext() : base("Server=ZoeVM; Database=samples;Integrated Security=True;")
        {

        }
              
        public DbSet<Attendance> Attendances { get; set;}
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Dentist> Dentists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SystemContext>(null);
            modelBuilder.Configurations.Add(new DentistMap());
            modelBuilder.Configurations.Add(new PacientMap());
            modelBuilder.Configurations.Add(new AttendanceMap());
            base.OnModelCreating(modelBuilder);
        }


    }
}
