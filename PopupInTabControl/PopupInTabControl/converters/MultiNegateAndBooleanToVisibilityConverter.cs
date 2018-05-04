using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts multi boolean to visibility.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class MultiNegateAndBooleanToVisibilityConverter : IMultiValueConverter
    {
        /// <inheritdoc />
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(values[0] is bool)
                || !(values[1] is bool))
                return Visibility.Hidden;

            if (!(bool)values[0]
                && !(bool)values[1])
                return Visibility.Visible;

            return Visibility.Hidden;
        }

        /// <inheritdoc />
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}