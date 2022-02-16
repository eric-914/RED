namespace RenderEngineDesktop.Models.Common
{
    public class PointModel<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public PointModel(T x = default!, T y = default!)
        {
            X = x;
            Y = y;
        }
    }

    //TODO: Figure out how to get XAML to accept PointModel<float> for DataContext definition
    public class PointModel : PointModel<float> { }
}
