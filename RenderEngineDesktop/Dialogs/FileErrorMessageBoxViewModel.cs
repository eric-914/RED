using RenderEngineDesktop.Annotations;
using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration.Support;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Dialogs;

public class FileErrorMessageBoxViewModel : INotifyPropertyChanged
{
    public event EventHandler? Close;

    private readonly ISystemInformation _system;

    private FileErrorMessageBoxModel _model = new();
    public FileErrorMessageBoxModel Model
    {
        get => _model;
        set
        {
            if (_model == value) return;

            _model = value;
            OnPropertyChanged();
        }
    }

    public ICommand OkCommand { get; }
    public ICommand BrowseCommand { get; }

    #region XAML Design

    //--Used by the XAML Designer
#pragma warning disable CS8618
    public FileErrorMessageBoxViewModel() { }
#pragma warning restore CS8618

    #endregion

    [Ninject.Inject]
    public FileErrorMessageBoxViewModel(ICommands commands, ISystemInformation system)
    {
        _system = system;

        OkCommand = commands.Action(Ok);
        BrowseCommand = commands.Action(Browse);
    }

    private void Ok()
    {
        Close?.Invoke(this, EventArgs.Empty);
    }

    private void Browse()
    {
        var path = Path.GetDirectoryName(Model.Path) ?? @"C:\";

        _system.OpenExplorer(path);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
