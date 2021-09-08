using System;
using System.Globalization;
using System.Windows.Data;

namespace Minesweeper.View.Converters
{
    public class BoolToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool val)) throw new ArgumentException($"The passed value must be of type {typeof(bool)}");
            return val ?  0 :  100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}