using RenderEngineDesktop.Models.Assets;
using System.Collections.Generic;
using System.Linq;

namespace RenderEngineDesktop.Models.Environment;

public class EnvironmentsModel : List<EnvironmentModel>
{
    public EnvironmentModel Selected { get; set; }

    public EnvironmentsModel()
    {
        var data = new List<EnvironmentModel>
        {
            new(Environments.Local, "Local Host", EnvironmentServers.Local, AssetServers.Dev, AssetFolders.Dev),
            new(Environments.Dev, "Dev", EnvironmentServers.Dev, AssetServers.Dev, AssetFolders.Dev),
            new(Environments.Test, "Test", EnvironmentServers.Test, AssetServers.Test, AssetFolders.Test),
            new(Environments.Stage, "Stage", EnvironmentServers.Stage, AssetServers.Stage, AssetFolders.Stage),
            new(Environments.Prod, "Prod", EnvironmentServers.Prod, AssetServers.Prod, AssetFolders.Prod),
        };

        AddRange(data);

        Selected = data.First();
    }
}
