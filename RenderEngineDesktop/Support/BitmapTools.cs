using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Support
{
    public interface IBitmapTools
    {
        BitmapImage ToBitmapImage(Bitmap src);
        BitmapImage ToBitmapImage(byte[] data);
        Bitmap ToBitmap(byte[] data);
        BitmapImage CreateBlankImage(int width, int height);
    }

    internal class BitmapTools : IBitmapTools
    {
        public BitmapImage ToBitmapImage(Bitmap src)
        {
            var ms = new MemoryStream();
            src.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            var image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();

            return image;
        }

        public BitmapImage ToBitmapImage(byte[] data)
        {
            return ToBitmapImage(ToBitmap(data));
        }

        public Bitmap ToBitmap(byte[] data)
        {
            var converter = new ImageConverter();

            var converted = converter.ConvertFrom(data);

            return (Bitmap)converted!;
        }

        public BitmapImage CreateBlankImage(int width, int height)
        {
            var bmp = new Bitmap(width, height);

            return ToBitmapImage(bmp);
        }
    }
}
