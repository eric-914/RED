using System;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters.Fields;

public abstract class FieldConverter<T> : IValueConverter
{
    private readonly Func<T, object?> _fn;

    public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is T o ? _fn(o) : null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    protected FieldConverter(Func<T, object?> fn)
    {
        _fn = fn;
    }
}
