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

namespace KSIS.UsersControl
{
    /// <summary>
    /// Логика взаимодействия для Authenication.xaml
    /// </summary>
    public partial class Authenication : UserControl
    {
        #region Variables
        #region String
        private String DefaultTextLogin = "Логин";
        private String DefaultTextPassword = "Пароль";
        #endregion
        #endregion
        public Authenication()
        {
            InitializeComponent();
            SettingToolTip();
            DataContext = new ViewModels.AuthViewModel();
            TimeSys.Hour.Foreground = new SolidColorBrush(Colors.White);
            TimeSys.Dot.Foreground = TimeSys.Hour.Foreground;
            TimeSys.Minute.Foreground = TimeSys.Hour.Foreground;
        }

        private void SettingSysBtn()
        {
            //BorderAuthForm
        }

        private void SettingToolTip()
        {
            TxtBoxLOGIN.ToolTip = ToolTips.Default("Логин пользователя", "Уникальный идентификатор пользователя");
        }

        #region Setting login text box
        private void TxtBoxLOGIN_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxLOGIN.Text == String.Empty)
            {
                TxtBoxLOGIN.Text = DefaultTextLogin;
                TxtBoxLOGIN.Foreground = new SolidColorBrush(Data.DefaultSettings.Colors.TipColorText);
            }
        }

        private void TxtBoxLOGIN_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxLOGIN.Text == DefaultTextLogin)
            {
                TxtBoxLOGIN.Text = String.Empty;
                TxtBoxLOGIN.Foreground = new SolidColorBrush(Data.DefaultSettings.Colors.DefaultColorText);
            }
        }
        #endregion

        #region Setting password box
        private void PassBoxPASSWORD_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PassBoxPASSWORD.Password == DefaultTextPassword)
            {
                PassBoxPASSWORD.Password = String.Empty;
                PassBoxPASSWORD.Foreground = new SolidColorBrush(Data.DefaultSettings.Colors.DefaultColorText);
            }
        }

        private void PassBoxPASSWORD_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PassBoxPASSWORD.Password == String.Empty)
            {
                PassBoxPASSWORD.Password = DefaultTextPassword;
                PassBoxPASSWORD.Foreground = new SolidColorBrush(Data.DefaultSettings.Colors.TipColorText);
            }
        }
        #endregion

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //AssignmentColor();
           // SettingLetterIcon();
            //SettingText();
            //SettingSysBtn();
        }

        private void BtnNewPass_Click(object sender, RoutedEventArgs e)
        {
            NewPassword newPassword = new NewPassword();
            newPassword.ShowDialog();
        }


    }
}
