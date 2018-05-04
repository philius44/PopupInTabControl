using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WuH.ServiceTool.Core.Presentation.Converters
{
    /// <summary>
    /// Converts the expander IsExpanded property to <see cref="GridUnitType" />.Star or <see cref="GridUnitType" />.Auto.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter" />
    public class ExpandedToGridLengthConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return GridLength.Auto;

            if ((bool) value)
                return new GridLength(1, GridUnitType.Star);

            return GridLength.Auto;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}