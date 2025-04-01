using Vigilance.Core;
using Vigilance.Drawing;
using Vigilance.Input;

var config = new GameConfig
{
    Title = "My Game",
    ExitKey = Key.Escape,
    FullscreenKey = Key.Tab,
    Icon = static () => Asset.ImageResource("icon.png"),
    WorkingModule = FileSystem.GameAssembly.GetName().Name! + ".Resources"
};

var scene = new Scene();

scene.OnUpdate(() =>
{
    Renderer.Graphics.ClearBackground(Color.Blue);
    Renderer.Graphics.FillText("Hello, World!", 4, 4, Color.Black);
});

Game.Launch(config, scene);
