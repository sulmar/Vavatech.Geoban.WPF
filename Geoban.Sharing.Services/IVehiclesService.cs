using Geoban.Sharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Services
{
    public interface IVehiclesService
    {
        IList<Vehicle> Get();

        Vehicle Get(int id);

        void Add(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Remove(int id);
    }
}
