using System;

namespace RenderEngineDesktop.Models.Environment
{
    public class EnvironmentModel
    {
        public Environments Environment { get; }
        public string Text { get; }
        public string Address { get; }
        public string AssetServer { get; }
        public string AssetFolder { get; }

        public Uri Uri => new(Address);

        public EnvironmentModel(Environments environment, string text, string address, string assetServer, string assetFolder)
        {
            Environment = environment;
            Text = text;
            Address = address;
            AssetServer = assetServer;
            AssetFolder = assetFolder;
        }
    }
}
