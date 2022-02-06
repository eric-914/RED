using RenderEngineDesktop.Main;
using System;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class ViewTabsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is ViewTabs p) return (int)p;
            if (value is ViewTabs v) return (int)v;

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is int p) return (ViewTabs)p;
            if (value is int v) return (ViewTabs)v;

            throw new NotImplementedException();
        }
    }
}
