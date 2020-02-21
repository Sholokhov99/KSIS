using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Source
{
    public class Colors
    {
        public static (byte, byte, byte, byte) ConvertArgbFromHex(String hex)
        {
            Int32 argb = Int32.Parse(hex.Replace("#", ""), System.Globalization.NumberStyles.HexNumber);
            System.Drawing.Color color = System.Drawing.Color.FromArgb(argb);
            return (A: (byte)color.A, R: (byte)color.R, G: (byte)color.G, B: (byte)color.B);
        }

        public static Color ConvertColorFromSolidColorBrush(SolidColorBrush brush)
        {
            var data = Colors.ConvertArgbFromHex(brush.Color.ToString());
            return Color.FromArgb(data.Item1, data.Item2, data.Item3, data.Item4);
        }
    }
}
