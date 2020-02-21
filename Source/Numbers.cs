using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Numbers
    {
        public class Conventer
        {
            public static Boolean IsInt32(String value) =>
        Int32.TryParse(value, out Int32 num);
            public static Boolean IsByte(String value) =>
                Byte.TryParse(value, out Byte num);
            public static Boolean IsFloat(String value) =>
                float.TryParse(value, out float num);
            public static Boolean IsDouble(String value) =>
                Double.TryParse(value, out Double num);
            public static Boolean IsShort(String value) =>
                Int16.TryParse(value, out Int16 num);
            public static Boolean IsBoolean(String value) =>
                Boolean.TryParse(value, out Boolean boolean);
        }
    }
}
