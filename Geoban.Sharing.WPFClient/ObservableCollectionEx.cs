using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.Sharing.WPFClient
{
    public class ObservableCollectionEx<T> : ObservableCollection<T>
        where T : INotifyPropertyChanged
    {
        public ObservableCollectionEx(IEnumerable<T> items)
            : base(items)
        {
            foreach (var item in items)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }
    }
}
