using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Common;
using RenderEngineDesktop.Support;
using System;
using System.IO;
using System.Windows.Input;

namespace RenderEngineDesktop.Dialogs.FileError;

public class FileErrorMessageBoxViewModel : NotifyModel
{
    public event EventHandler? Close;

    private readonly ISystemInformation _system;

    public ICommand OkCommand { get; }
    public ICommand BrowseCommand { get; }

    private FileErrorMessageBoxModel _model = new();
    public FileErrorMessageBoxModel Model
    {
        get => _model;
        set => Set(_model == value, () => _model = value);
    }

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
}
