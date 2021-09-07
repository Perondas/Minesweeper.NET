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
                    return Colors.Blue;
                case 2:
                    return Colors.Green;
                case 3:
                    return Colors.Red;
                case 4:
                    return Colors.Purple;
                case 5:
                    return Colors.Maroon;
                case 6:
                    return Colors.Turquoise;
                case 7:
                    return Colors.Black;
                case 8:
                    return Colors.Gray;
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