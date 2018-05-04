using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts boolean to visibility switched to <see cref="BooleanToVisibilityConverter" />.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class SftThreeColumnsConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
                return ((double)value - 12) / 3;
            return 0;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}