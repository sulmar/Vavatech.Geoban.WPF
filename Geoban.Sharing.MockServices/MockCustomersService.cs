using Geoban.Sharing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geoban.Sharing.Models;

namespace Geoban.Sharing.MockServices
{
    public class MockCustomersService : ICustomersService
    {
        private IList<Customer> customers = new List<Customer>
        {
           new Customer { CustomerId = 1, FirstName = "Marcin", LastName = "Sulecki", Age = 18},
           new Customer { CustomerId = 2, FirstName = "Bartek", LastName = "Sulecki", Age = 9},
           new Customer { CustomerId = 3, FirstName = "Kasia", LastName = "Sulecka", Age = 18},

        };

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> Get()
        {
            return customers;
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
