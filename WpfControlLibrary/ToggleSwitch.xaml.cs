using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public SolidColorBrush InactiveColor =  new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        public SolidColorBrush ActiveColor = new SolidColorBrush(Color.FromArgb(255, 0, 184, 148));
        public Boolean Checked { get; set; } = false;

        public UserControl1()
        {
            InitializeComponent();
            backgroundToggleSwitch.Fill = InactiveColor;
        }

        //public void InactiveColor(Color color)

        private void toggleSwitchBUTTON_Click(object sender, RoutedEventArgs e)
        {
            Color.FromArgb(255, 10, 10, 10);
            Timer timer = new Timer();
            timer.Interval = 2;
            timer.Start();

            timer.Elapsed += (g, q) =>
            {
                Application.Current.Dispatcher.Invoke(new System.Action(() => SetControl(toggleSwitchBUTTON, (int)gridToggleSwitch.Width, timer)));
            };
        }

        public void SetControl(Control control, Int32 widthGrid, Timer timer)
        {
            if (!Checked)
            {
                if ((control.Width + control.Margin.Left) != widthGrid - 2)
                {
                    control.Margin = new Thickness(control.Margin.Left + 1, control.Margin.Top, control.Margin.Right, control.Margin.Bottom);
                }
                else
                {
                    Checked = true;
                    timer.Stop();
                    backgroundToggleSwitch.Fill = ActiveColor;
                }
            }
            else
            {
                if (control.Margin.Left != 2)
                {
                    control.Margin = new Thickness(control.Margin.Left - 1, control.Margin.Top, control.Margin.Right, control.Margin.Bottom);
                }
                else
                {
                    Checked = false;
                    timer.Stop();
                    backgroundToggleSwitch.Fill = InactiveColor;
                }
            }
        }
    }
}
