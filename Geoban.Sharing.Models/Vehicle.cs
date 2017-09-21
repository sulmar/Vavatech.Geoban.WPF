using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Models
{
    public abstract class Vehicle : Base
    {
        public int VehicleId { get; set; }

        public string Name { get; set; }

        public int ProductionYear { get; set; }

        #region Price

        private decimal _Price;
        public decimal Price
        {
            get { return _Price; }
            set
            {
                _Price = value;

                // NET 4.0
                OnPropertyChanged(() => Price);

                // .NET 4.5
                // OnPropertyChanged();

                // C# 6.0
               // OnPropertyChanged(nameof(Price));

                // OnPropertyChanged(() => Price);
            }
        }

        #endregion
    }
}
