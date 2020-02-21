using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Source
{
    public partial class Image
    {
        private static Bitmap ImageNotFound = Properties.Resources.ImageNotFound;
        public static ImageSource ConvertBitmapToImageSource(Bitmap value)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                value.Save(ms, ImageFormat.Jpeg);
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                ms.Seek(0, SeekOrigin.Begin); img.StreamSource = ms;
                img.EndInit();
                return img;
            }
        }

        public static async Task<String> ConvertBitmapToStringAsync(Bitmap value)
        {
            await Task.Run(() =>
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    value.Save(stream, ImageFormat.Png);
                    return Convert.ToBase64String(stream.ToArray());
                }
            });
            return "";

        }

        public static ImageSource ConvertStringToImageSource(String value) =>
            ImageSourceFromBitmap(ConvertStringToBitmap(value));

        //
        //  Конвентирование из System.String в System.Drawing.Bitmap
        //
        public static Bitmap ConvertStringToBitmap(String value)
        {
            try
            {
                return new Bitmap(new MemoryStream(Convert.FromBase64String(value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ImageNotFound;
            }
        }

        public static ImageSource ImageSourceFromBitmap(Bitmap bitmap) =>
            Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

        public static ImageBrush ImageBrushFromBitmap(Bitmap bitmap)
        {
            ImageBrush imageBrush = new ImageBrush()
            {
                ImageSource = ImageSourceFromBitmap(bitmap)
            };
            return imageBrush;
        }

        public static ImageBrush ImageBrushFromUri(String uri)
        {
            try
            {
                String path = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), uri);
                return new ImageBrush(new BitmapImage(new Uri(path)));
            }
            catch
            {
                return ImageBrushFromBitmap(Properties.Resources.ImageNotFound);
            }
        }

        public static Bitmap GetImageNotFount() =>
            Properties.Resources.ImageNotFound;
    }
}
