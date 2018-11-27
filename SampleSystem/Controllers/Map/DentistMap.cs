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
            this.Property(d => d.Id).HasColumnName("Id_DENTIST");
            this.Property(d => d.Name).HasColumnName("Name_DENTIST");
            this.Property(d => d.Email).HasColumnName("Email_DENTIST");
            this.Property(d => d.Phone).HasColumnName("Phone_DENTIST");
            this.Property(d => d.Cellphone).HasColumnName("Cellphone_DENTIST");
            this.Property(d => d.Number).HasColumnName("Number");
        }
    }
}
