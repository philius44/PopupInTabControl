using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Inverts a boolean.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class InvertBoolConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool booleanValue = (bool)value;
            return !booleanValue;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool booleanValue = (bool)value;
            return !booleanValue;
        }
    }
}