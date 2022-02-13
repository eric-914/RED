using System.Diagnostics;

namespace RenderEngineDesktop.Support
{
    public static class FileExplorer
    {
        public static void Open(string path)
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
