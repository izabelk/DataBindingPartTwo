namespace Earth.Data.Repositories
{
    using Earth.Data.UnitOfWork;
    using Earth.Models;

    public class TownsRepository : GenericRepository<Town>, IGenericRepository<Town>
    {
        public TownsRepository(IEarthDbContext context)
            : base(context)
        {
        }
    }
}