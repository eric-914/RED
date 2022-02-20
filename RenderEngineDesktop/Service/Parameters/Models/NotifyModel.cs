using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RenderEngineDesktop.Annotations;

namespace RenderEngineDesktop.Service.Parameters.Models
{
    public abstract class NotifyModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void Set(bool compare, Action set, [CallerMemberName] string? propertyName = null)
        {
            if (compare) return;
            set();
            OnPropertyChanged(propertyName);
        }

        #endregion
    }
}
