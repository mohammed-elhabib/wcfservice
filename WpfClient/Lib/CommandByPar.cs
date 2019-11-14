using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfClient.Lib
{
    public class CommandByPar : ICommand
    {
        private Action<object> _action;

        public event EventHandler CanExecuteChanged;
         public CommandByPar(Action<object> _action) {
             this._action = _action;

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._action(parameter);
        }
    }
}
