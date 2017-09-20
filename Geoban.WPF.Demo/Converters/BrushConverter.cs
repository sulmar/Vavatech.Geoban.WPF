using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Geoban.WPF.Demo.Converters
{

    class BrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var age = (byte)value;

            if (age > 18)
            {
                return new SolidColorBrush(Colors.Green);
            }
            else
            {
                return new SolidColorBrush(Colors.Red);
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
