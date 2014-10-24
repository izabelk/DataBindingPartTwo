namespace Earth.Data.UnitOfWork
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Earth.Models;

    public interface IEarthDbContext
    {
        IDbSet<Continent> Continents { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}