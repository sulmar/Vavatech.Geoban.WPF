using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Models
{
    public class Rental : Base
    {
        public int RentalId { get; set; }

        public Customer Rentee { get; set; }

        public Vehicle Vehicle { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public decimal? Cost { get; set; }
    }
}
