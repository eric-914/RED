using RenderEngineDesktop.Service.Parameters.Models;
using System;
using System.Runtime.CompilerServices;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationWindowModel : NotifyModel
    {
        //--Ah yes, comparing doubles...
        private void Set(double a, double b, Action action, [CallerMemberName] string? propertyName = null) 
            => Set(Math.Abs(a - b) < 1, action, propertyName);

        private double _left;
        public double Left
        {
            get => _left;
            set => Set(_left, value, () => _left = value);
        }

        private double _top;
        public double Top
        {
            get => _top;
            set => Set(_top, value, () => _top = value);
        }

        private double _width;
        public double Width
        {
            get => _width;
            set => Set(_width, value, () => _width = value);
        }

        private double _height;
        public double Height
        {
            get => _height;
            set => Set(_height, value, () => _height = value);
        }
    }
}
