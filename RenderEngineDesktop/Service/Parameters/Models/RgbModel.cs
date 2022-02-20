namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// For holding Red/Green/Blue int values
    /// </summary>
    public class RgbModel
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public RgbModel()
        {
            Red = Green = Blue = -1;
        }

        public RgbModel(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
