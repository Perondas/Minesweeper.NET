using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Minesweeper.View.Converters
{
    public class CellNumberColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int num)) throw new ArgumentException($"The value must be of type {typeof(int)}");
            switch (num)
            {
                case 1:
                    return new SolidColorBrush(Colors.Blue);
                case 2:
                    return new SolidColorBrush(Colors.Green);
                case 3:
                    return new SolidColorBrush(Colors.Red);
                case 4:
                    return new SolidColorBrush(Colors.Purple);
                case 5:
                    return new SolidColorBrush(Colors.Maroon);
                case 6:
                    return new SolidColorBrush(Colors.Turquoise);
                case 7:
                    return new SolidColorBrush(Colors.Black);
                case 8:
                    return new SolidColorBrush(Colors.Gray);
                default:
                    throw new ArgumentOutOfRangeException("The value must be between 1 and 9");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}