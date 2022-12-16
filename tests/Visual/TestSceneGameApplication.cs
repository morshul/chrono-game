using NUnit.Framework;
using osu.Framework.Platform;

namespace chrono.Game.Tests.Visual;

[TestFixture]
public partial class TestSceneGameApplication : GameApplicationTestScene
{
    private GameApplication? game;

    [BackgroundDependencyLoader]
    private void load(GameHost host)
    {
        game = new GameApplication();
        game.SetHost(host);

        AddGame(game);
    }
}
