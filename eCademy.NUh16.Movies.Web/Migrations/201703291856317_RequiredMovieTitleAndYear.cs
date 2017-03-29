namespace eCademy.NUh16.Movies.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredMovieTitleAndYear : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
