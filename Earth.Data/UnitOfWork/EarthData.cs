namespace Earth.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;

    using Earth.Data.Repositories;
    using Earth.Models;

    public class EarthData : IEarthData
    {
        private IEarthDbContext context;
        private IDictionary<Type, object> repositories;

        public EarthData()
            : this(new EarthDbContext())
        {
        }

        public EarthData(IEarthDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public ContinentsRepository Continents
        {
            get
            {
                return (ContinentsRepository)this.GetRepository<Continent>();
            }
        }

        public CountriesRepository Countries
        {
            get
            {
                return (CountriesRepository)this.GetRepository<Country>();
            }
        }

        public TownsRepository Towns
        {
            get
            {
                return (TownsRepository)this.GetRepository<Town>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                if (typeOfModel.IsAssignableFrom(typeof(Continent)))
                {
                    type = typeof(ContinentsRepository);
                }
                else if (typeOfModel.IsAssignableFrom(typeof(Country)))
                {
                    type = typeof(CountriesRepository);
                }
                else if (typeOfModel.IsAssignableFrom(typeof(Town)))
                {
                    type = typeof(TownsRepository);
                }

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}