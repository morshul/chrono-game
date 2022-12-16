using chrono.Game;
using osu.Framework;

using var host = Host.GetSuitableDesktopHost(@"chrono-trigger");
using var game = new GameApplication();

host.Run(game);
