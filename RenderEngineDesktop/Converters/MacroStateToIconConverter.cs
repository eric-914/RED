using RenderEngineDesktop.Models.Macros;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace RenderEngineDesktop.Converters
{
    public class MacroStateToIconConverter : IValueConverter
    {
        private static readonly Dictionary<MacroStates, string> Lookup = new()
        {
            {MacroStates.None, "/Resources/Blank.png" },
            {MacroStates.Recording, "/Resources/Record.png"},
            {MacroStates.Running, "/Resources/Run.png"},
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MacroStates s)
            {
                return Lookup[s];
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
