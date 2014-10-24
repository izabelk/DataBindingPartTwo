namespace Earth.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Earth.Data.UnitOfWork;
    using Earth.Models;

    public sealed class Configuration : DbMigrationsConfiguration<EarthDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EarthDbContext context)
        {
            if (!context.Continents.Any())
            {
                context.Continents.AddOrUpdate(
                    new Continent { Name = "Africa" },
                    new Continent { Name = "Asia" },
                    new Continent { Name = "North America" },
                    new Continent { Name = "South America" },
                    new Continent { Name = "Europe" },
                    new Continent { Name = "Australia" },
                    new Continent { Name = "Antarctica" });
            }

            if (!context.Countries.Any())
            {
                context.Countries.AddOrUpdate(
                   new Country { Name = "Nigeria", Language = "English", Population = 923.768m, ContinendId = 1 },
                   new Country { Name = "Egypt", Language = "Arabic", Population = 10001.449m, ContinendId = 1 },
                   new Country { Name = "Ghana", Language = "English", Population = 238.534m, ContinendId = 1 },
                   new Country { Name = "Japan", Language = "Japanese", Population = 126999.808m, ContinendId = 2 },
                   new Country { Name = "China", Language = "Chinese", Population = 1363950000m, ContinendId = 2 },
                   new Country { Name = "India", Language = "Hindi", Population = 1236344.631m, ContinendId = 2 },
                   new Country { Name = "United States", Language = "English", Population = 316102000m, ContinendId = 3 },
                   new Country { Name = "Canada", Language = "English", Population = 35236000m, ContinendId = 3 },
                   new Country { Name = "Mexico", Language = "English", Population = 118419000m, ContinendId = 3 },
                   new Country { Name = "Brazilia", Language = "Portuguese", Population = 201033000m, ContinendId = 4 },
                   new Country { Name = "Colombia", Language = "Spanish", Population = 47130000m, ContinendId = 4 },
                   new Country { Name = "Peru", Language = "Spanish", Population = 30476000m, ContinendId = 4 },
                   new Country { Name = "Germany", Language = "German", Population = 80996685m, ContinendId = 5},
                   new Country { Name = "France", Language = "French", Population = 66259012m, ContinendId = 5 },
                   new Country { Name = "Bulgaria", Language = "Bulgarian", Population = 6924716m, ContinendId = 5 },
                   new Country { Name = "Australia", Language = "English", Population = 23640800m, ContinendId = 6 });
            }

            if (!context.Towns.Any())
            {
                context.Towns.AddOrUpdate(
                    new Town { Name = "Sofia", Population = 12345m, CountryId = 15 },
                    new Town { Name = "Berlin", Population = 12346m, CountryId = 13 },
                    new Town { Name = "Paris", Population = 12347m, CountryId = 14 });
            }
        }
    }
}