using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    /// <summary>
    /// The inverse of the BooleanToVisibilityConverter.
    /// Hide when true, Show when false.
    /// </summary>
    public class BooleanToVisibilityInverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool v)
            {
                return !v ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility v)
            {
                return v != Visibility.Visible;
            }

            return true;
        }
    }
}
