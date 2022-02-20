namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// A way to make a Size object for different number types
    /// </summary>
    public class SizeModel<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }

        public SizeModel(T width = default!, T height = default!)
        {
            Width = width;
            Height = height;
        }
    }

    //TODO: Figure out how to get XAML to accept SizeModel<int> for DataContext definition
    public class SizeModel : SizeModel<int> { }
}
