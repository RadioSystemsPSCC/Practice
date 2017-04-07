using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels.Commands
{
    class ViewCommand : ICommand
    {
        public Signature7ViewModel sigViewModel { get; set; }

        public ViewCommand(Signature7ViewModel signatureVM)
        {
            this.sigViewModel = signatureVM;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.sigViewModel.ViewCommand();
        }
    }
}