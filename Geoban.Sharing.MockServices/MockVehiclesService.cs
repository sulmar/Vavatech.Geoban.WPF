using Geoban.Sharing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geoban.Sharing.Models;

namespace Geoban.Sharing.MockServices
{
    public class MockVehiclesService : IVehiclesService
    {

        private IList<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleId = 1, Name = "Toyota", ProductionYear = 2010, Capacity = 1.8m, Price = 99 },
            new Car { VehicleId = 2, Name = "Mazda", ProductionYear = 2014, Capacity = 1.8m, Price = 99 },
            new Bike { VehicleId = 3, Name = "Romet", ProductionYear = 2014, Price = 9 },
        };

        public void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public IList<Vehicle> Get()
        {
            return vehicles;
        }

        public Vehicle Get(int id)
        {
            return vehicles.Single(v => v.VehicleId == id);
        }

        public void Remove(int id)
        {
            var vehicle = Get(id);

            vehicles.Remove(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
