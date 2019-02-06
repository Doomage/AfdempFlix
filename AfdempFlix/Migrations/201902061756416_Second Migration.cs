namespace AfdempFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "TrailerUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ThumbnailUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ThumbnailUrl", c => c.String());
            AlterColumn("dbo.Movies", "TrailerUrl", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
