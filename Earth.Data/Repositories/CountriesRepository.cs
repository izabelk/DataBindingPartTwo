namespace Earth.Data.Repositories
{
    using Earth.Data.UnitOfWork;
    using Earth.Models;

    public class CountriesRepository : GenericRepository<Country>, IGenericRepository<Country>
    {
        public CountriesRepository(IEarthDbContext context)
            : base(context)
        {
        }
    }
}