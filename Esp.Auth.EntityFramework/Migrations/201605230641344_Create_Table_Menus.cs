namespace Esp.Auth.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Menus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        MenuName = c.String(),
                        DisplayName = c.String(),
                        MenuUrl = c.String(),
                        MenuCss = c.String(),
                        IsExpand = c.Boolean(nullable: false),
                        Parent_Id = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Menu_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "Parent_Id", "dbo.Menus");
            DropIndex("dbo.Menus", new[] { "Parent_Id" });
            DropTable("dbo.Menus",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Menu_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
