using System.Windows.Media;

namespace RenderEngineDesktop.Views.Logging;

public static class LogColors
{
    public static readonly SolidColorBrush Information = new(Color.FromRgb(192, 192, 0));
    public static readonly SolidColorBrush Error = new(Color.FromRgb(255, 92, 64));
    public static readonly SolidColorBrush Exception = new(Color.FromRgb(224, 0, 0));
}