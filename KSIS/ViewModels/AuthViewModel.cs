using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Prism.Commands;

namespace KSIS.ViewModels
{
    class AuthViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChamged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private String _hex;

        public String Hex
        {
            get { return _hex; }
            set
            {
                _hex = value;
                OnPropertyChamged();
            }
        }

        #region Variables
        #region private
        private String _loginUser;
        private String _passwordUser;
        private Boolean _signAccount;

        private String _defaultLoginText = @"Логин";
        private String _defaultPasswordTExt = @"Пароль";
        #endregion

        #region public

        public ICommand LoginTextBox { get; private set; }


        public String StrLoginUser
        {
            get { return _loginUser; }
            set
            {
                _loginUser = value;
                OnPropertyChamged();
            }
        }

        public String StrPasswordUser
        {
            get { return _passwordUser; }
            set
            {
                _passwordUser = value;
                OnPropertyChamged();
            }
        }

        public Boolean SignAccount
        {
            get { return _signAccount; }
            set
            {
                _signAccount = value;
                OnPropertyChamged();
            }
        }
        #endregion
        #endregion

        public AuthViewModel()
        {
            StrLoginUser = _defaultLoginText;
            StrPasswordUser = _defaultPasswordTExt;

            LoginTextBox = new DelegateCommand(ExecuteLoginTxtBox, CanExecuteLoginTxtBox);

            Hex = "#CC0000FF";
        }

        #region Настройка текстового поля
        #region Login Text box
        public void LoginTextBox_LostFocus()
        {
            if (StrLoginUser == _defaultLoginText)
            {
                StrLoginUser = String.Empty;
                //TxtBoxLOGIN.Foreground = new SolidColorBrush(Data.DefaultSettings.Colors.DefaultColorText);
            }
        }



        private bool CanExecuteLoginTxtBox() => true;

        private void ExecuteLoginTxtBox()
        {
            
        }

        #endregion
        #endregion

    }
}
