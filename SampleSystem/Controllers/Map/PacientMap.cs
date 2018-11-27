using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Controllers.Map
{
    class PacientMap : EntityTypeConfiguration<Pacient>
    {
        public PacientMap()
        {
            this.ToTable("Pacient");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("ID_PACIENT");
            this.Property(p => p.Name).HasColumnName("Name_PACIENT");
            this.Property(p => p.Email).HasColumnName("Email_PACIENT");
            this.Property(p => p.Phone).HasColumnName("Phone_PACIENT");
            this.Property(p => p.Cellphone).HasColumnName("Cellphone_PACIENT");
            this.Property(p => p.Zip).HasColumnName("Zip_PACIENT");
            this.Property(p => p.Address).HasColumnName("Address_PACIENT");
            this.Property(p => p.Complement).HasColumnName("Complement_PACIENT");
            this.Property(p => p.Born).HasColumnName("Born_PACIENT");
            this.Property(p => p.Sex).HasColumnName("Sex_PACIENT");
        }
    }
}
