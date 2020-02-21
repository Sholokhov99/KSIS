using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace KSIS.Data
{
    class DynamicView
    {
        #region Color
        public static Color MainColor { get; set; }
        #endregion

        #region Font
        public static FontFamily MainFontFamily { get; set; }
        public static FontFamily MainIconFontFamily { get; set; }
        public static FontStyle MainFontStyle { get; set; }
        public static Byte MainSizeText { get; set; }
        #endregion

        #region Background
        public static ImageBrush BackImageAuth { get; set; }
        public static ImageBrush BackImageAcc { get; set; }
        #endregion

        #region SpecialFeature
        public static Boolean EyeProblemsAuth { get; set; }
        #endregion

        #region Data User
        public static Boolean EyeProblemsAcc { get; set; }
        #endregion
    }
}
