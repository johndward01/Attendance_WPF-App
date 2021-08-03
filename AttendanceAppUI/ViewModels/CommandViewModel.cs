using AttendanceAppUI.Views;
using System;
using System.Windows.Input;

namespace AttendanceAppUI.ViewModels
{
    internal class CommandViewModel : BaseViewModel
    {
        public CommandViewModel(string displayName, ICommand command)
        {
            Name = displayName;
            Command = command ?? throw new ArgumentNullException("command");
        }

        public ICommand Command { get; private set; }
    }
    
}
