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
                        ID_Pacient = c.Int(nullable: false),
                        Date_Attendance = c.DateTime(),
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
                "dbo.Pacient",
                c => new
                    {
                        ID_Pacient = c.Int(nullable: false, identity: true),
                        Name_Pacient = c.String(),
                        Email_Pacient = c.String(),
                        Phone_Pacient = c.Long(nullable: false),
                        Cellphone_Pacient = c.Long(nullable: false),
                        Zip_Pacient = c.String(),
                        Address_Pacient = c.String(),
                        Complement_Pacient = c.String(),
                        Born_Pacient = c.DateTime(nullable: false),
                        Sex_Pacient = c.String(),
                    })
                .PrimaryKey(t => t.ID_Pacient);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacient");
            DropTable("dbo.Dentist");
            DropTable("dbo.Attendance");
        }
    }
}
