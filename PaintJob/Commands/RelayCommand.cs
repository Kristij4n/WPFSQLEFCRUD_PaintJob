using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PaintJob.Commands
{
    public class RelayCommand : ICommand
    {

        // use for job operations

        #region Job EventHandler

        public event EventHandler CanExecuteChanged;

        private Action DoJob;
        public RelayCommand(Action job)
        {
            DoJob = job;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoJob();
        }

        #endregion

    }
}
