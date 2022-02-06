using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    /// <summary>
    /// Split string embedded with carriage returns
    /// </summary>
    public class SplitStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string s 
                ? s.Split(Environment.NewLine) 
                : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is IEnumerable<string> s
                ? string.Join(Environment.NewLine, s)
                : new List<string>();
        }
    }
}
