namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MySkills", "SkillName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MySkills", "SkillName", c => c.Int(nullable: false));
        }
    }
}
