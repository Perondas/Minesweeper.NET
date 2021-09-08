using System;
using System.Globalization;
using System.Windows.Data;

namespace Minesweeper.View.Converters
{
    /// <summary>
    /// A class to be used as a value multiplier of two double values.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class ValueMultiplier : IValueConverter
    {
        /// <summary>
        /// Multiplies a value by the parameter.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. Else if the conversion fails null.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                double original = System.Convert.ToDouble(value);
                double factor = System.Convert.ToDouble(parameter);

                return original * factor;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Converts a value back by dividing it by the parameter.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. Else if the conversion fails null.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                double original = System.Convert.ToDouble(value);
                double factor = System.Convert.ToDouble(parameter);

                return original / factor;
            }
            catch
            {
                return null;
            }
        }
    }
}
