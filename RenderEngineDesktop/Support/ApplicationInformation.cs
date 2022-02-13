using System;
using System.IO;
using System.Reflection;

namespace RenderEngineDesktop.Support
{
    public static class ApplicationInformation
    {
        public static string AssemblyName
            => Assembly.GetExecutingAssembly().GetName().Name
               ?? AppDomain.CurrentDomain.FriendlyName;

        public static string ApplicationDataFolder() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static string ApplicationDataFolder(string localFolder)
        {
            return Path.Combine(ApplicationDataFolder(), localFolder);
        }

        public static string ApplicationFolder() => ApplicationDataFolder(AssemblyName);
    }
}
