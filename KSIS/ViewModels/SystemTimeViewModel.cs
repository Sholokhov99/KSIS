using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Prism.Commands;
using System.Timers;

namespace KSIS.ViewModels
{
    class SystemTimeViewModel : INotifyPropertyChanged
    {
        private Timer _timer;
        private Timer _animationTimer;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChamged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #region Variable
        //  8:05 PM
        private String _hour;
        private String _minute;
        private String _dot;


        public String Hour
        {
            get { return _hour; }
            set 
            {
                _hour = value;
                OnPropertyChamged();
            }
        }

        public String Minute
        {
            get { return _minute; }
            set
            {
                _minute = value;
                OnPropertyChamged();
            }
        }

        public String Dot
        {
            get { return _dot; }
            set
            {
                _dot = value;
                OnPropertyChamged();
            }
        }
        #endregion

        public SystemTimeViewModel()
        {
            LoadData();
            _timer = new Timer()
            {
                Interval = 1000,
                AutoReset = true,
                Enabled = true,
            };
            _timer.Elapsed += (s, e) =>
            {
                LoadData();

            };
            _timer.Start();



        }

        private void LoadData()
        {
            Hour = DateTime.Now.Hour.ToString();
            Minute = DateTime.Now.Minute.ToString();

            if (Dot != String.Empty)
                Dot = String.Empty;
            else 
                Dot = ":";

            GC.Collect();
        }
    }
}
