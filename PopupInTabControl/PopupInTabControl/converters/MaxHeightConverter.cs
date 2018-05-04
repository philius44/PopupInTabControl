using System;
using System.Globalization;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class MaxHeightConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double doubleValue = 0;

            if ((double) value == 0)
                return doubleValue;

            if ((double) value - (double) parameter < (double) parameter)
                return value;

            doubleValue = (double) value - (double) parameter;
            return doubleValue;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}