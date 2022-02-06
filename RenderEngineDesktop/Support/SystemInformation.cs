using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.IoC;

namespace RenderEngineDesktop.Support
{
    public interface ISystemInformation
    {
        string ApplicationLocalFolder();
        void OpenExplorer(string path);
    }

    internal class SystemInformation : ISystemInformation
    {
        private readonly IFactory _factory;

        public SystemInformation(IFactory factory)
        {
            _factory = factory;
        }

        public string AssemblyName
            => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
               ?? System.AppDomain.CurrentDomain.FriendlyName;

        public string ApplicationFolder() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public string ApplicationFolder(string localFolder)
        {
            string path = Path.Combine(ApplicationFolder(), localFolder);
            
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

        public string ApplicationLocalFolder() => ApplicationFolder(AssemblyName);

        public void OpenExplorer(string path)
        {
            var info = new ProcessStartInfo
            {
                FileName = path,
                WorkingDirectory = path,
                UseShellExecute = true,
                Verb = "open"
            };

            Process.Start(info);
        }
    }
}
