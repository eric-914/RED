namespace RenderEngineDesktop.Models.Common
{
    public class PointModel<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public PointModel(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
