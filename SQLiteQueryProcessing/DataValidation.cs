using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteQueryProcessing
{
    public class DataValidation
    {
        static List<Char> ErrorLetyters = new List<Char>()
        { 
            '/', '|', '\\', '"', '\'', '.', ',', ' ' 
        };
        public class ColumnOptions
        {
            public class TableUsers
            {
                // глобус
                public static ValueTuple<Byte, Byte> LengthLogin { get; } = (5, 35);
                public static ValueTuple<Byte, Byte> LengthPassword { get; } = (5, 35);
                public static ValueTuple<Byte, Byte> LengthNameAndSurname { get; } = (1, 255);
                public static ValueTuple<Byte, Byte> LengthMail { get; } = (5, 255);
                public static ValueTuple<Byte, Byte> LengthSecretQuestion { get; } = (1, 255);

            }

            public static Boolean CheckValidation(String value, ValueTuple<Byte, Byte> tuple)
            {
                if (value.Length >= tuple.Item1 && value.Length <= tuple.Item2)
                {
                    for (Int32 index = 0; index < value.Length; index++)
                    {
                        foreach (Char letter in ErrorLetyters)
                        {
                            if (letter == value[index]) return false;
                        }
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
