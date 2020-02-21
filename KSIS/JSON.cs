using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using KSIS.Data;
using Newtonsoft.Json;

namespace KSIS
{
    class JSON
    {
        public class Authenication
        {
            private static String PathJsonFile = @"Authform.json";
            public class Data
            {
                public String FontFamily { get; set; }
                public String FontSize { get; set; }
                public String FontStyle { get; set; }
                public String ColorProgram { get; set; }
                public String BackImage { get; set; }
                public String EyeProblems { get; set; }
            }
            //
            //  Считывание Json файла
            //
            public void DeserializeJson()
            {
                Data data;
                if (File.Exists(PathJsonFile))
                {
                    try
                    {
                        data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(PathJsonFile));
                    }
                    catch
                    {
                        data = NotJsonFile();
                    }
                }
                else
                {
                    data = NotJsonFile();
                }
                SetDynamicView(data);
            }
            //
            //  Запись в Json файл
            //
            public static void SerializeJson(String nameFontFamily, String fontSize, String fontStyle, String hex, String uriImage, String eyeProblems)
            {
                var data = new Data()
                {
                    FontFamily = nameFontFamily,
                    FontSize = fontSize,
                    FontStyle = fontStyle,
                    ColorProgram = hex,
                    BackImage = uriImage,
                    EyeProblems = eyeProblems,
                };
                File.WriteAllText(PathJsonFile, JsonConvert.SerializeObject(data));
            }

            //
            //  Json файл не найден или имеет ошибку
            //
            private Data NotJsonFile()
            {
                var data = DefSetting();
                File.WriteAllText(PathJsonFile, JsonConvert.SerializeObject(data));
                return data;
            }
            //
            //  Установка стандартных настроек формы авторизации
            //
            private Data DefSetting()
            {
                var data = new Data
                {
                    FontFamily = DefaultSettings.Text.MainFontFamily.Source,
                    FontSize = DefaultSettings.Text.FontSize.ToString(),
                    FontStyle = DefaultSettings.Text.FontStyle.ToString(),
                    ColorProgram = "#FF" + DefaultSettings.Colors.MainDefColor.R.ToString("X2") + DefaultSettings.Colors.MainDefColor.G.ToString("X2") + DefaultSettings.Colors.MainDefColor.B.ToString("X2"),
                    BackImage = "Default",
                    EyeProblems = DefaultSettings.SpecialFeature.EyeProblemsAuth.ToString(),
                };
                return data;
            }
            //
            //  Определение стиля шрифта
            //
            private FontStyle SwitchFontStyle(String value)
            {
                value = value.ToLower();
                if (value == "italic") return FontStyles.Italic;
                else if (value == "oblique") return FontStyles.Oblique;
                else return FontStyles.Normal;
            }
            //
            //  Загрузка изображения
            //
            private ImageBrush SwitchBacmImageAuth(String uri)
            {
                if (uri.ToLower() == "default")
                {
                    return DefaultSettings.Image.BackImgAuth;
                }
                else
                {
                    return Source.Image.ImageBrushFromUri(uri);
                }
            }
            //
            //  Занесение данных в память приложения
            //
            private void SetDynamicView(Data data)
            {


                DynamicView.MainFontFamily = new FontFamily(data.FontFamily);
                DynamicView.MainSizeText = (Source.Numbers.Conventer.IsByte(data.FontSize) && (Convert.ToByte(data.FontSize) >= DefaultSettings.Size.MinSizeText && Convert.ToByte(data.FontSize) <= DefaultSettings.Size.MaxSizeText)) ? Convert.ToByte(data.FontSize) : DefaultSettings.Size.MainSizeText;
                var color = Source.Colors.ConvertArgbFromHex(data.ColorProgram);
                DynamicView.MainColor = Color.FromArgb(255, color.Item2, color.Item3, color.Item4);
                DynamicView.MainFontStyle = SwitchFontStyle(data.FontStyle);
                DynamicView.BackImageAuth = SwitchBacmImageAuth(data.BackImage);
                DynamicView.EyeProblemsAuth = (Source.Numbers.Conventer.IsBoolean(data.EyeProblems)) ? Convert.ToBoolean(data.EyeProblems) : DefaultSettings.SpecialFeature.EyeProblemsAuth;
            }
        }
    }
}
