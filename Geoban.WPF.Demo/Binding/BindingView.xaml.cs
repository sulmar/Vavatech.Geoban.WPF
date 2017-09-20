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
    /// Interaction logic for BindingView.xaml
    /// </summary>
    public partial class BindingView : Window
    {
        public BindingView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.FirstName.Text = "Bartek";
        }
    }
}
