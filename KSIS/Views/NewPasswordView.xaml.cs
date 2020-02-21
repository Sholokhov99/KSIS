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
using System.Windows.Shapes;

namespace KSIS
{
    /// <summary>
    /// Логика взаимодействия для NewPassword.xaml
    /// </summary>
    public partial class NewPassword : Window
    {
        #region Variables
        private String StrLogin { get; set; }
        private String StrPassUser { get; set; }
        private String StrSecretQuestion { get; set; }
        private String StrAnswerSecretQuestion { get; set; }
        private Byte Steep { get; set; } = 0;
        #endregion
        public NewPassword()
        {
            InitializeComponent();
            PassPASSWORDBOX.Visibility = Visibility.Collapsed;
            GenerateElements();
        }

        private String Steeps(Byte value)
        {
            switch (value)
            {
                case 0: return "Введите логин от аккаунта.";
                case 1: return "Введите ответ на секретный вопрос.";
                case 2: return "Введите новый пароль.";
                case 3: return "Подтвердите новый пароль.";
                case 4: return "Измененение пароля прошло успешно!Теперь можете авторизироваться с новым паролем.";
                default: return "*Ошибка*";
            }

        }


        private void GenerateElements()
        {
            TipTextLABEL.Content = Steeps(Steep);
        }

        private void NextSteepBUTTON_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;

            switch (Steep)
            {
                //
                //  Проверка введенного пароля
                //
                case 0:
                    // Соединение с бд и получение секретного слова и вопрос
                    var data = SQLiteQueryProcessing.SQL.VerifyingPassRecoveryData(DataSetTEXTBOX.Text);
                    if (data.Item1 != String.Empty)
                    {
                        this.StrLogin = DataSetTEXTBOX.Text;
                        this.StrSecretQuestion = data.Item1;
                        this.StrAnswerSecretQuestion = data.Item2;
                        Steep++;
                        this.TipTextLABEL.Content = $"Напишите ответ на вопрос:";
                        this.LblSecretText.Content = this.StrSecretQuestion;
                        this.LblSecretText.Visibility = Visibility.Visible;
                    }
                    else
                        MessageBox.Show("Пользователь не найден");
                    break;

                //
                // Проверка на корректный ответ на секретный вопрос
                //
                case 1:
                    if (DataSetTEXTBOX.Text == this.StrAnswerSecretQuestion)
                    {
                        this.LblSecretText.Visibility = Visibility.Collapsed;
                        this.TipTextLABEL.Content = "Введите новый пароль: ";
                    }
                    else MessageBox.Show("OopS");
                    break;

                //
                // Создание нового пароля
                //
                case 2:
                    if (SQLiteQueryProcessing.DataValidation.ColumnOptions.CheckValidation(DataSetTEXTBOX.Text, SQLiteQueryProcessing.DataValidation.ColumnOptions.TableUsers.LengthLogin))
                    {
                        StrLogin = DataSetTEXTBOX.Text;
                        Steep++;
                    }
                    else
                        MessageBox.Show("Пароль не соответствует системе безопастности");
                    break;

                //
                // Проверка на соответствие пароля
                //
                case 3:
                    if (StrLogin == DataSetTEXTBOX.Text)
                    { 
                    
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    break;
            }
            DataSetTEXTBOX.Text = String.Empty;
            this.IsEnabled = true;
            GC.Collect();
        }
    }
}
