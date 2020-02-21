using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace KSIS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            //SQLiteQueryProcessing.SQL.OpenConnectLocalDB();
            //WriteJson();
            InitializeComponent();
            Source.UpdateSystemTime.StartUpdateSystemTime();

        }

        private void MainGrid_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
        /*
private void WriteJson()
{
   JSON.Authenication authenicationJson = new JSON.Authenication();
   JSON.Authenication.Data data = new JSON.Authenication.Data();
   authenicationJson.DeserializeJson();
}

private void Window_Loaded(object sender, RoutedEventArgs e)
{
   this.Background = Data.DynamicView.BackImageAuth;
}*/
    }
}
