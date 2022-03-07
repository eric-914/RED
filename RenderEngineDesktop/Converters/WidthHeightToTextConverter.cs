using System;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class WidthHeightToTextConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is double dw && values[1] is double dh)
            {
                return $"{dw:0} x {dh:0}";
            }

            if (values[0] is int iw && values[1] is int ih)
            {
                return $"{iw} x {ih}";
            }

            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
