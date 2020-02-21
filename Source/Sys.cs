using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Sockets;
using System.Net;

namespace Source
{
    public class Sys
    {
        public static String WayFileHostsWin() =>
     $"{PositionOS()}Windows\\System32\\drivers\\etc";
        public class Fonts
        {
            public static List<String> GetSysFonts()
            {
                var fonts = new List<String>();
                foreach (FontFamily font in FontFamily.Families)
                    fonts.Add(font.Name);
                return fonts;
            }
        }

        public static String PositionOS() =>
            Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

        public static String GetLocalIP()
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint iPEndPoint = socket.LocalEndPoint as IPEndPoint;
                    return iPEndPoint.Address.ToString();
                }
            }
            catch
            {
                return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            }
        }

        public class SystemTime
        { 
        
        }
    }
}
