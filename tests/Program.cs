using chrono.Game.Tests;
using osu.Framework;

using var host = Host.GetSuitableDesktopHost(@"chrono-trigger_visual-tests", new HostOptions
{
    PortableInstallation = true
});
using var game = new GameApplicationTestBrowser();

host.Run(game);
