using System;
using System.Globalization;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts byte arrays to string.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class ByteArrayToStringConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = BitConverter.ToString((byte[]) value);
            return stringValue.Replace("-", "");
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}