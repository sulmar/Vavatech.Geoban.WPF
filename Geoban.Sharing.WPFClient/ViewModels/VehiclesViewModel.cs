using Geoban.Sharing.DbServices;
using Geoban.Sharing.MockServices;
using Geoban.Sharing.Models;
using Geoban.Sharing.Services;
using Geoban.WPF.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Geoban.Sharing.WPFClient.ViewModels
{
    public class VehiclesViewModel : ViewModelBase
    {
        public IList<Vehicle>  Vehicles { get; set; }

        #region SelectedVehicle

        private Vehicle _SelectedVehicle;
        public Vehicle SelectedVehicle
        {
            get
            {
                return _SelectedVehicle;
            }

            set
            {
                _SelectedVehicle = value;

                OnPropertyChanged();
            }
        }

        #endregion

        private IVehiclesService vehiclesService;

        public VehiclesViewModel()
        {
            vehiclesService = new MockVehiclesService();

            Load();
        }

        public void Load()
        {
            Vehicles = new ObservableCollectionEx<Vehicle>(vehiclesService.Get());

        }


        #region CalculateCommand

        public ICommand CalculateCommand
        {
            get
            {
                return new RelayCommand(p => Calculate(p), p => CanCalculate());
            }
        }


        public void Calculate(object parameter)
        {
            SelectedVehicle.Price = 44;
        }

        public bool CanCalculate()
        {
            return SelectedVehicle != null && SelectedVehicle.Price > 50;
        }


        #region ShowCommand

        public ICommand ShowCommand
        {
            get
            {
                return new RelayCommand(p => Show(), p => CanShow());
            }
        }

        public void Show()
        {
            // MessageBox.Show("Hello");

            Views.VehicleView vehicleView = new Views.VehicleView(SelectedVehicle);
            vehicleView.ShowDialog();
        }

        public bool CanShow()
        {
            return SelectedVehicle != null;
        }

        #endregion

        #endregion

    }
}
