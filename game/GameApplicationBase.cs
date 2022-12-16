global using osu.Framework.Allocation;
using chrono.Game.Resources;
using osu.Framework.IO.Stores;

namespace chrono.Game;

public abstract partial class GameApplicationBase : osu.Framework.Game
{
    private DependencyContainer? dependencies;

    [BackgroundDependencyLoader]
    private void load()
    {
        Resources.AddStore(new DllResourceStore(ChronoResources.Assembly));

        Host.Window.Title = "CHRONO TRIGGER";
    }

    protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
        => dependencies = new DependencyContainer(base.CreateChildDependencies(parent));
}
