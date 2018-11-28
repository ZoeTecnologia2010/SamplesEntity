using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Controllers.Map
{
    class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            this.ToTable("Patient");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("ID_Patient");
            this.Property(p => p.Name).HasColumnName("Name_Patient");
            this.Property(p => p.Email).HasColumnName("Email_Patient");
            this.Property(p => p.Phone).HasColumnName("Phone_Patient");
            this.Property(p => p.Cellphone).HasColumnName("Cellphone_Patient");
            this.Property(p => p.Zip).HasColumnName("Zip_Patient");
            this.Property(p => p.Address).HasColumnName("Address_Patient");
            this.Property(p => p.Complement).HasColumnName("Complement_Patient");
            this.Property(p => p.Born).HasColumnName("Born_Patient");
            this.Property(p => p.Sex).HasColumnName("Sex_Patient");
        }
    }
}
