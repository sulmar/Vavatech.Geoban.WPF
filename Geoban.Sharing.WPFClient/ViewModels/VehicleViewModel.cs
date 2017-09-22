using Geoban.Sharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.WPFClient.ViewModels
{
    public class VehicleViewModel : ViewModelBase
    {
        private Vehicle _Vehicle;
        public Vehicle Vehicle
        {
            get
            {
                return _Vehicle;
            }
            set
            {
                _Vehicle = value;
                OnPropertyChanged();
            }
        }
    }
}
