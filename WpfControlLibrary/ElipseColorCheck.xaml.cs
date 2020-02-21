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
    /// Логика взаимодействия для ElipseColorCheck.xaml
    /// </summary>
    public partial class ElipseColorCheck : UserControl
    {
        public Boolean IsMouseEnter { get; set; }  = false;
        public SolidColorBrush BackColor
        {
            get { return BackColor; }
            set
            {
                ElipseColor.Background = value;
            }
        }
        public SolidColorBrush BorderColor{ get; set; }  = new SolidColorBrush(Color.FromArgb(255,70,70,70));
        public Byte BorderSize { get; set; } = 2;

        public ElipseColorCheck()
        {
            InitializeComponent();
            //ElipseColor.Background = BackColor;
            ElipseColor.BorderThickness = new Thickness(0);
            ElipseColor.BorderBrush = BorderColor;
            ElipseColor.Background = new SolidColorBrush(Color.FromRgb(87, 75, 144));
            ElipseColor.Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            IsMouseEnter = true;
            ElipseColor.BorderThickness = new Thickness(BorderSize);
        }


        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            IsMouseEnter = false;
            ElipseColor.BorderThickness = new Thickness(0);
            
        }
        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);
           // MessageBox.Show("Click");
        }

    }
}
