using Vigilance.Core;
using Vigilance.Drawing;
using Vigilance.Input;

var config = new GameConfig
{
    Title = "My Game",
    ExitKey = Key.Escape,
    FullscreenKey = Key.Tab
};

var scene = new Scene();

scene.OnUpdate(() =>
{
    Renderer.Graphics.ClearBackground(Color.Blue);
});

Game.Launch(config, scene);
