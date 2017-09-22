using Geoban.Sharing.Models;
using Geoban.Sharing.WPFClient.ViewModels;
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

namespace Geoban.Sharing.WPFClient.Views
{
    /// <summary>
    /// Interaction logic for VehicleView.xaml
    /// </summary>
    public partial class VehicleView : Window
    {
        public VehicleView(Vehicle vehicle)
        {
            InitializeComponent();

            var vm = (VehicleViewModel)this.DataContext;

            vm.Vehicle = vehicle;
        }
    }
}
