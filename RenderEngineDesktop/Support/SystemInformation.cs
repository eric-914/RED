using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.IoC;
using System;
using System.IO;

namespace RenderEngineDesktop.Support
{
    public interface ISystemInformation
    {
        string ApplicationFolder();
        void OpenExplorer(string path);
    }

    internal class SystemInformation : ISystemInformation
    {
        private readonly IFactory _factory;

        public SystemInformation(IFactory factory)
        {
            _factory = factory;
        }

        public string ApplicationFolder() => ValidateApplicationFolder(ApplicationInformation.ApplicationFolder());

        public string ValidateApplicationFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    _factory.Get<IDialogManager>()
                        .ShowPathError(e, path,
                            "An error occurred while trying to create the local application folder:",
                            "",
                            "Application must now exit.");

                    Environment.Exit(0);
                }
            }

            return path;
        }


        public void OpenExplorer(string path) => FileExplorer.Open(path);
    }
}
