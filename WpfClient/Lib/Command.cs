using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfClient.Lib
{
    public class Command : ICommand
    {
        private Action _action;

        public event EventHandler CanExecuteChanged;
         public   Command(Action _action) {
             this._action = _action;

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._action();
        }
    }
}
