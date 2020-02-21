using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace KSIS.Data
{
    class DefaultSettings
    {
        public class Colors
        {
            public static Color MainDefColor { get; } = Color.FromArgb(255, 87, 75, 144);
            public static Color MainTransparentColor { get; } = Color.FromArgb(150, 87, 75, 144);
            public static Color TipColorText { get; } = Color.FromRgb(122, 122, 122);
            public static Color DefaultColorText { get; } = Color.FromRgb(0, 0, 0);
            public static Color MainDarkColor { get; } = Color.FromArgb(255, 82, 70, 139);
            public static Color MainDefBorderColor { get; } = Color.FromArgb(150, 29, 17, 90);
            public static Color MainLightBorderColor { get; } = Color.FromArgb(150, 58, 46, 121);
        }
        public class Size
        {
            public static Byte MinSizeText { get; } = 8;
            public static Byte MaxSizeText { get; } = 16;
            public static Byte MainSizeText { get; } = 12;
        }

        public class Text
        {
            public static Byte FontSize { get; } = 12;
            public static FontStyle FontStyle = FontStyles.Normal;
            public static FontFamily MainFontFamily { get; } = new FontFamily("Tahoma");
            public static FontFamily MainIconFontFamily { get; } = new FontFamily(new Uri(@"pack://application:,,,/resources/Font/Awesome5/"), "./#FontAwesome");
        }

        public class Image
        {
            public static ImageBrush BackImgAuth { get; } = Source.Image.ImageBrushFromBitmap(Properties.Resources.Background);
            public static ImageBrush BackImgAcc { get; } = Source.Image.ImageBrushFromBitmap(Properties.Resources.Background);
            public static System.Drawing.Bitmap NotImage { get; } = Source.Image.GetImageNotFount();

        }

        public class SpecialFeature
        {
            public static Boolean EyeProblemsAuth { get; } = false;
            public static Boolean EyeProblemsAcc { get; } = false;
        }
    }
}
