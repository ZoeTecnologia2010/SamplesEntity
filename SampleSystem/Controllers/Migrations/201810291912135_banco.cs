namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        ID_Attendance = c.Int(nullable: false, identity: true),
                        ID_Dentist = c.Int(nullable: false),
                        ID_Patient = c.Int(nullable: false),
                        DateTime_Attendance = c.DateTime(),
                        TimeSelect_Attendance = c.DateTime(),
                        TimeStart_Attendance = c.DateTime(),
                        TimeFinish_Attendance = c.DateTime(),
                        Obs_Attendance = c.String(),
                        Status_Attendance = c.String(),
                    })
                .PrimaryKey(t => t.ID_Attendance);
            
            CreateTable(
                "dbo.Dentist",
                c => new
                    {
                        ID_Dentist = c.Int(nullable: false, identity: true),
                        Name_Dentist = c.String(),
                        Email_Dentist = c.String(),
                        Phone_Dentist = c.Long(nullable: false),
                        Cellphone_Dentist = c.Long(nullable: false),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.ID_Dentist);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        ID_Patient = c.Int(nullable: false, identity: true),
                        Name_Patient = c.String(),
                        Email_Patient = c.String(),
                        Phone_Patient = c.Long(nullable: false),
                        Cellphone_Patient = c.Long(nullable: false),
                        Zip_Patient = c.String(),
                        Address_Patient = c.String(),
                        Complement_Patient = c.String(),
                        Born_Patient = c.DateTime(nullable: false),
                        Sex_Patient = c.String(),
                    })
                .PrimaryKey(t => t.ID_Patient);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patient");
            DropTable("dbo.Dentist");
            DropTable("dbo.Attendance");
        }
    }
}
