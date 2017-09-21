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

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                OnPropertyChanged();
                OnPropertyChanged(() => FullName);
            }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value;
                OnPropertyChanged();
                OnPropertyChanged(() => FullName);
            }
        }


        public string FullName => $"{FirstName} {LastName}";

        public byte Age { get; set; }

        public Address HomeAddress { get; set; }

    }
}
