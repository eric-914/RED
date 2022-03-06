using System.Drawing;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationWindowModel
    {
        public Point Position { get; set; } = new();
        public Size Size { get; set; } = new(770, 460);
    }
}
