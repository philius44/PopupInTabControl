using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts boolean to visibility.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return Visibility.Hidden;

            var hiddenVisibility = Visibility.Collapsed;
            if (parameter is Visibility)
                hiddenVisibility = Visibility.Hidden;

            if (value is bool)
                return (bool) value ? Visibility.Visible : hiddenVisibility;
            return Visibility.Collapsed;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return (Visibility) value == Visibility.Visible ? true : false;
            return false;
        }
    }
}