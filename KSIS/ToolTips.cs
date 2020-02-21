using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KSIS
{
    public class ToolTips
    {
        /*
        private static ToolTip Tip { get; set; }
        private static Grid ToolTipPanel { get; set; }
        private static Rectangle BorderPanel { get; set; }
        private static Grid IconPanel { get; set; }
        private static Label IconLbl { get; set; }
        private static StackPanel ContentToolTipStackPanel { get; set; }
        private static Label TitleLabel { get; set; }
        private static Rectangle LineTitleTextRect { get; set; }
        private static Label ContextLabel { get; set; }*/


        public static ToolTip Default(String titleText, String contextText)
        {
            //  BorderPanel
            var BorderPanel = new Rectangle()
            {
                Stroke = new SolidColorBrush(Data.DynamicView.MainColor),
                RadiusX = 8,
                RadiusY = 8,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Fill = new SolidColorBrush(Color.FromRgb(224, 224, 224)),
                StrokeThickness = 1,
            };

            //  IconLbl
            var IconLbl = new Label()
            {
                Content = Data.LettersFontAwesome.Fa_Slideshare,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = new SolidColorBrush(Data.DynamicView.MainColor),
            };

            //  IconPanel
            var IconPanel = new Grid();
            IconPanel.Children.Add(IconLbl);

            //  TitleLabel
            var TitleLabel = new Label()
            {
                Content = titleText,
                Foreground = new SolidColorBrush(Data.DynamicView.MainColor),
            };

            //  LineTitleTextRect
            var LineTitleTextRect = new Rectangle()
            {
                Height = 1,
                Fill = new SolidColorBrush(Color.FromRgb(224, 224, 224)),
                HorizontalAlignment = HorizontalAlignment.Stretch,
            };

            //  ContextLabel
            var ContextLabel = new Label()
            {
                Content = contextText,
                Foreground = new SolidColorBrush(Color.FromRgb(224, 224, 224)),
            };

            //  ContentToolTipStackPanel
            var ContentToolTipStackPanel = new StackPanel();
            ContentToolTipStackPanel.Children.Add(TitleLabel);
            ContentToolTipStackPanel.Children.Add(LineTitleTextRect);
            ContentToolTipStackPanel.Children.Add(ContextLabel);

            //  ContentToolTipWrapPanel
            var ContentToolTipWrapPanel = new WrapPanel();
            ContentToolTipWrapPanel.Children.Add(IconPanel);
            ContentToolTipWrapPanel.Children.Add(ContentToolTipStackPanel);

            //  ToolTipPanel
            var ToolTipPanel = new Grid();
            ToolTipPanel.Children.Add(BorderPanel);
            ToolTipPanel.Children.Add(ContentToolTipWrapPanel);

            var toolTip = new ToolTip()
            {
                Background = new SolidColorBrush(Colors.Transparent),
                BorderBrush = new SolidColorBrush(Colors.Transparent),
                Content = ToolTipPanel,
            };
            return toolTip;

            /*
            //
            //  BorderPanel
            //
            BorderPanel = new Rectangle()
            {
                Stroke = new SolidColorBrush(Data.DynamicView.MainColor),
                RadiusX = 8,
                RadiusY = 8,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Fill = new SolidColorBrush(Color.FromRgb(224,224,224)),
                StrokeThickness = 1,
                
            };
            //
            //  IconLbl
            //
            IconLbl = new Label()
            {
                Content = Data.LettersFontAwesome.Fa_Slideshare,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5,0,5,0),
                Foreground = new SolidColorBrush(Data.DynamicView.MainColor),
            };
            //
            //  TitleLabel
            //
            TitleLabel = new Label()
            {
                Content = titleText,
                Foreground = new SolidColorBrush(Data.DynamicView.MainColor),
            };
            //
            //  LineTitleTextRect
            //
            LineTitleTextRect = new Rectangle()
            { 
                Height = 1,
                Fill = new SolidColorBrush(Color.FromRgb(224, 224, 224)),
                HorizontalAlignment = HorizontalAlignment.Stretch,
            };
            //
            //  ContextLabel
            //
            ContextLabel = new Label()
            { 
                Content = contextText,
                Foreground = new SolidColorBrush(Color.FromRgb(224, 224, 224)),
            };
            //
            //  ContentToolTipStackPanel
            //
            ContentToolTipStackPanel = new StackPanel();
            ContentToolTipStackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            ContentToolTipStackPanel.Children.Add(TitleLabel);
            ContentToolTipStackPanel.Children.Add(LineTitleTextRect);
            ContentToolTipStackPanel.Children.Add(ContextLabel);
            //
            //  ToolTipPanel
            //
            ToolTipPanel = new Grid();
            ToolTipPanel.Children.Add(BorderPanel);
            ToolTipPanel.Children.Add(IconLbl);
            ToolTipPanel.Children.Add(ContentToolTipStackPanel);
            //
            //  Tip
            //
            Tip = new ToolTip();
            Tip.Content = ToolTipPanel;
            return Tip;*/
        }

    }
}
