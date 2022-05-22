using RenderEngineDesktop.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters;

internal class ApiVersionToIsCheckedConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ApiVersions v && parameter is ApiVersions p)
        {
            return v == p;
        }

        throw new NotImplementedException();
    }

    public object? ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool v && parameter is ApiVersions p)
        {
            return v ?  p : null;
        }

        throw new NotImplementedException();
    }
}