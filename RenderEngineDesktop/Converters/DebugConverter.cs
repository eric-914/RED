using System;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    /// <summary>
    /// This can be used for debugging bindings.
    /// </summary>
    /// <remarks>
    /// Just add this converter to the binding you want to debug, and set the breakpoints below.
    /// </remarks>
    public class DebugConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
