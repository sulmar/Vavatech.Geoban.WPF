using Geoban.Sharing.MockServices;
using Geoban.Sharing.Models;
using Geoban.Sharing.Services;
using Geoban.WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.Sharing.WPFClient.ViewModels
{
    public class CustomersViewModel : ViewModelBase
    {
        public IList<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        private ICustomersService customersService;

        public CustomersViewModel()
        {
            customersService = new MockCustomersService();

            Load();
        }

        private void Load()
        {
            Customers = customersService.Get();
        }


        public ICommand SendCommand
        {
            get
            {
                return new RelayCommand(p => Send(), p => CanSend());
            }
        }

        public void Send()
        {
            Console.WriteLine($"Sending to {SelectedCustomer.FullName}");

        }

        public bool CanSend()
        {
            return SelectedCustomer != null && SelectedCustomer.Age >= 18;
        }


    }
}
