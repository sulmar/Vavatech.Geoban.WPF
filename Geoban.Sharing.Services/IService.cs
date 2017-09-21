using Geoban.Sharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Services
{
    public interface IService<TItem>
    {
        IList<TItem> Get();

        TItem Get(int id);

        void Add(TItem item);

        void Update(TItem item);

        void Remove(int id);
    }


    public interface ICustomersService : IService<Customer>
    {
    }

    public interface IRentalsService : IService<Rental>
    {

    }
}
