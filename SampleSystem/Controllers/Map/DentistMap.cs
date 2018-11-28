using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class DentistMap : EntityTypeConfiguration<Dentist>
    {
        public DentistMap()
        {
            this.ToTable("Dentist");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_Dentist");
            this.Property(d => d.Name).HasColumnName("Name_Dentist");
            this.Property(d => d.Email).HasColumnName("Email_Dentist");
            this.Property(d => d.Phone).HasColumnName("Phone_Dentist");
            this.Property(d => d.Cellphone).HasColumnName("Cellphone_Dentist");
            this.Property(d => d.Number).HasColumnName("Number");
        }
    }
}
