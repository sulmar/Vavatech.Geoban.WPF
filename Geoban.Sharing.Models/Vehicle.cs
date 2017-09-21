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

        public decimal Price { get; set; }
    }
}
