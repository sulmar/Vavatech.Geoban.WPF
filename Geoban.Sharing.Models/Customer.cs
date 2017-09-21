using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Models
{
    public class Customer : Base
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public byte Age { get; set; }

        public Address HomeAddress { get; set; }

    }
}
