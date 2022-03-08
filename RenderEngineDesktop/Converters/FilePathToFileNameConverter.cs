using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class FilePathToFileNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string p)
            {
                return Path.GetFileName(p);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
