using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class ListStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is IEnumerable<string> s
                ? string.Join(Environment.NewLine, s)
                : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string s
                ? new List<string>(s.Split(Environment.NewLine))
                : new List<string>();
        }
    }
}
