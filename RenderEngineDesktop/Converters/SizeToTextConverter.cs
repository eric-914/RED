using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class SizeToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Size s)
            {
                return $"{s.Width} x {s.Height}";
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
