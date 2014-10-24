namespace Earth.Data.Repositories
{
    using Earth.Data.UnitOfWork;
    using Earth.Models;

    public class ContinentsRepository : GenericRepository<Continent>, IGenericRepository<Continent>
    {
        public ContinentsRepository(IEarthDbContext context)
            : base(context)
        {
        }
    }
}