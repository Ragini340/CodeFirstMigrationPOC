﻿namespace CodeFirstMigrationPOC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForRoleInEmp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Role");
        }
    }
}
