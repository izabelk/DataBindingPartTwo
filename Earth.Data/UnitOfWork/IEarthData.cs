namespace Earth.Data.UnitOfWork
{
    using Earth.Data.Repositories;

    public interface IEarthData
    {
        ContinentsRepository Continents { get; }

        CountriesRepository Countries { get; }

        TownsRepository Towns { get; }

        void SaveChanges();
    }
}