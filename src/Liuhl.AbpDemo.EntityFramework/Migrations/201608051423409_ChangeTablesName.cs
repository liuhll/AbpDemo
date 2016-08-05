namespace Liuhl.AbpDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablesName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpLanguages", newName: "Languages");
            RenameTable(name: "dbo.AbpLanguageTexts", newName: "LanguageTexts");
            RenameTable(name: "dbo.AbpRoles", newName: "Roles");
            RenameTable(name: "dbo.AbpUsers", newName: "Users");
            RenameTable(name: "dbo.AbpUserLogins", newName: "UserLogins");
            RenameTable(name: "dbo.AbpUserRoles", newName: "UserRoleMaps");
            RenameTable(name: "dbo.AbpSettings", newName: "Settings");
            RenameTable(name: "dbo.AbpTenants", newName: "Tenants");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tenants", newName: "AbpTenants");
            RenameTable(name: "dbo.Settings", newName: "AbpSettings");
            RenameTable(name: "dbo.UserRoleMaps", newName: "AbpUserRoles");
            RenameTable(name: "dbo.UserLogins", newName: "AbpUserLogins");
            RenameTable(name: "dbo.Users", newName: "AbpUsers");
            RenameTable(name: "dbo.Roles", newName: "AbpRoles");
            RenameTable(name: "dbo.LanguageTexts", newName: "AbpLanguageTexts");
            RenameTable(name: "dbo.Languages", newName: "AbpLanguages");
        }
    }
}
