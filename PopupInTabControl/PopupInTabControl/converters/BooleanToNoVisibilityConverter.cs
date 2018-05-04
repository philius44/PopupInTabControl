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
    public class BooleanToNoVisibilityConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
                return (bool) value ? Visibility.Collapsed : Visibility.Visible;
            return Visibility.Visible;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return (Visibility) value == Visibility.Collapsed ? true : false;
            return false;
        }
    }
}