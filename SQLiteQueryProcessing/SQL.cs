using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SQLiteQueryProcessing
{
    public class SQL
    {
        //private static String StrConnectString { get; } = @"Data Source=.\\data.db3;Version=3;Password=i@nF4Cu*U}*I";
        private static String StrConnectString { get; } = @"Data Source=.\\Database.db3;Version=3;";
        private static SQLiteConnection ConnectLocalDB = new SQLiteConnection(StrConnectString);
        //
        // Login: dako
        // Password: lbr100ru
        //
        public static void OpenConnectLocalDB()
        {
            ConnectLocalDB.Open();
        }

        public static void CloseConnectLocalDB()
        {
            ConnectLocalDB.Close();
        }

        #region SELECT
        private static List<String> Select(SQLiteCommand sQLiteCommand)
        {
            List<String> data = new List<string>();
           // ConnectLocalDB.Open();
            using (SQLiteDataReader qLiteDataReader = sQLiteCommand.ExecuteReader())
            {
                if (qLiteDataReader.HasRows)
                {
                    qLiteDataReader.Read();
                    for (Int32 index = 0; index < qLiteDataReader.FieldCount; index++)
                    {
                        data.Add(qLiteDataReader[index].ToString());
                    }
                }
                //ConnectLocalDB.Close();
                return data;
            }
        }
        public static (String, String) VerifyingPassRecoveryData(String login)
        {

            using (SQLiteCommand qLiteCommand = new SQLiteCommand("SELECT SecretQuestion, AnswerSecretQuestion FROM Users WHERE Login=@login", ConnectLocalDB))
            {
                qLiteCommand.Parameters.Add("@login", DbType.String, DataValidation.ColumnOptions.TableUsers.LengthPassword.Item2).Value = login;
                var data = Select(qLiteCommand);
                if (data.Count == 0)
                    return (String.Empty, String.Empty);
                else
                    return (data[0], data[1]);
            }
        }

        #endregion

        #region Update

        private static Int32 Update(String sql)
        {
            return -1;
        }

        public static Int32 UpdatePassword(String login, String password)
        {
            using (SQLiteCommand qLiteCommand = new SQLiteCommand("UPDATE Users SET Password=@password WHERE Login=@login", ConnectLocalDB))
            {
                qLiteCommand.Parameters.Add("@password", DbType.String, DataValidation.ColumnOptions.TableUsers.LengthPassword.Item2).Value = password;
                qLiteCommand.Parameters.Add("@login", DbType.String, DataValidation.ColumnOptions.TableUsers.LengthLogin.Item2).Value = login;
            }
            return -1;
        }
        #endregion

    } 
}
