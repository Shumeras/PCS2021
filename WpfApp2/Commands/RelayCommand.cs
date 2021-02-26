using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2.Commands
{
    class RelayCommand : ICommand
    {

        public Action<object> action;
        private bool isEnabled;

        public bool IsEnabled 
        { 
            get => isEnabled; 
            set
            {
                if (isEnabled == value) return;

                isEnabled = value;
                CanExecuteChanged(this, null);
            }
        }

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> action, bool isEnabled = true)
        {
            this.action = action;
            this.isEnabled = isEnabled;
        }

        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
