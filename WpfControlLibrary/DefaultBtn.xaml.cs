using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для DefaultBtn.xaml
    /// </summary>
    public partial class DefaultBtn : UserControl
    {
        public DefaultBtn()
        {
            InitializeComponent();

            //this.Content = "Ты кто";
            Btn.Style = this.FindResource("DefBtn") as Style;
            Content = new Button() { Content = "Eeee" };


            //Background = new SolidColorBrush(Color.FromRgb(87, 75, 144));
            /*
            Btn.Click += (s, e) => { Background = new SolidColorBrush(Colors.Azure); };*/

            /*
            GlobalSetting();*/
            //Style = Application.Current.FindResource("Button") as Style;
        }

        private void GlobalSetting()
        {
            Content = @"Это кнопка";
            Background = new SolidColorBrush(Color.FromArgb(255, 87, 75, 144));
            Width = 142;
            Height = 37;
            Foreground = new SolidColorBrush(Colors.White);
            //Style = Application.Current.FindResource("Button") as Style;
        }

    }
}
