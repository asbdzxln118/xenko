
using SiliconStudio.Xenko.Engine;

namespace SpriteEntity
{
    class SpriteEntityApp
    {
        static void Main(string[] args)
        {
            // Profiler.EnableAll();
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}