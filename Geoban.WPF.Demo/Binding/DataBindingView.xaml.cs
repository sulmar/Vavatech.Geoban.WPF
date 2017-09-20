using Geoban.WPF.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Geoban.WPF.Demo.Binding
{
    /// <summary>
    /// Interaction logic for DataBindingView.xaml
    /// </summary>
    public partial class DataBindingView : Window
    {

        public DataBindingView()
        {
            InitializeComponent();

            Customer customer = new Customer
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Age = 18,
                HomeAddress = new Address
                {
                    City = "Warszawa",
                    Street = "Powstańców Śląskich",
                    Postcode = "01-466"
                },
                WorkAddress = new Address
                {
                    City = "Wrocław",
                    Street = "Szewska 6/7",
                    Postcode = ""
                }

            };

            this.DataContext = customer;
        }
    }
}
