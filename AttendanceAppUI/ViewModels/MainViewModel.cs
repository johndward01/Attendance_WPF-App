using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AttendanceAppUI.ViewModels;

namespace AttendanceAppUI.Views
{
    class MainViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }
}
