namespace RenderEngineDesktop.Models.Common
{
    /// <summary>
    /// A way to make a Size object for different number types
    /// </summary>
    public class SizeModel<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }

        public SizeModel(T width, T height)
        {
            Width = width;
            Height = height;
        }
    }
}
