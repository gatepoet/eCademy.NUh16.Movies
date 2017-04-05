namespace eCademy.NUh16.Movies.Web.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eCademy.NUh16.Movies.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "eCademy.NUh16.Movies.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedGenres(context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private static void SeedGenres(ApplicationDbContext context)
        {
            var noGenre = new Models.Genre
            {
                Id = "none",
                Name = "None"
            };
            context.Genres.AddOrUpdate(
                noGenre,
                new Models.Genre
                {
                    Id = "action",
                    Name = "Action"
                }
            );

            context.Movies
                .Where(movie => movie.Genre == null)
                .ToList()
                .ForEach(movie => movie.Genre = noGenre);

            context.SaveChanges();
        }
    }
}
