using System;
using System.Globalization;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// multi or boolean converter.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class MultiOrBooleanConverter : IMultiValueConverter
    {
        /// <inheritdoc />
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(values[0] is bool)
                || !(values[1] is bool))
                return false;

            if ((bool) values[0]
                || (bool) values[1])
                return true;

            return false;
        }

        /// <inheritdoc />
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}