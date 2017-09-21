using Geoban.Sharing.MockServices;
using Geoban.Sharing.Models;
using Geoban.Sharing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.WPFClient.ViewModels
{
    public class VehiclesViewModel : ViewModelBase
    {
        public IList<Vehicle>  Vehicles { get; set; }

        private IVehiclesService vehiclesService;

        public VehiclesViewModel()
        {
            vehiclesService = new MockVehiclesService();

            Load();
        }

        public void Load()
        {
            Vehicles = vehiclesService.Get();
        }



    }
}
