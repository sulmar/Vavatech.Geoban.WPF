﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.Models
{
    public class Customer : Base
    {
        public int CustomerId { get; set; }

        private string _FirstName;
        [DisplayName("Imię")]
        [ReadOnly(true)]
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

        [DisplayName("Nazwisko")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value;
                OnPropertyChanged();
                OnPropertyChanged(() => FullName);
            }
        }

        [DisplayName("Imię i nazwisko")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} z {HomeAddress.City}";
            }
        }

        [DisplayName("Wiek")]
        public byte Age { get; set; }

        public Address HomeAddress { get; set; }

        public Customer()
        {
            HomeAddress = new Address();

            HomeAddress.PropertyChanged += HomeAddress_PropertyChanged;

        }

        private void HomeAddress_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "City")
            {
                OnPropertyChanged(nameof(FullName));
            }
        }
    }
}
