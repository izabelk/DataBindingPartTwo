namespace Earth.Data.UnitOfWork
{
    using System.Data.Entity;

    using Earth.Models;
    using Earth.Data.Migrations;

    public class EarthDbContext : DbContext, IEarthDbContext
    {
        public EarthDbContext()
            : base("Earth")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EarthDbContext, Configuration>());
        }

        public IDbSet<Continent> Continents { get; set; }

        public IDbSet<Country> Countries { get; set; }

        public IDbSet<Town> Towns { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}