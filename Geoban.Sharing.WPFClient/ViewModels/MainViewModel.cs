using Geoban.WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.Sharing.WPFClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public IList<ViewModelBase> ViewModels { get; set; }

        #region SelectedViewModel

        private ViewModelBase _SelectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get
            {
                return _SelectedViewModel;
            }

            set
            {
                _SelectedViewModel = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public MainViewModel()
        {
            SelectedViewModel = new CustomersViewModel();
        }


        public ICommand ShowCommand
        {
            get
            {
                return new RelayCommand(p => Show());
            }
        }

        private void Show()
        {

            SelectedViewModel = new CustomerViewModel();

        }
    }
}
