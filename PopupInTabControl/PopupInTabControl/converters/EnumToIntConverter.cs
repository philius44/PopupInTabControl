using System;
using System.Globalization;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts enum to integer.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class EnumToIntConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = (int) value;
            return intValue;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}