using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels.Commands
{
    public class SubmitCommand : ICommand
    {
        public Order Order { get; set; }

        public SubmitCommand(Order order)
        {
            this.Order = order;
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
            Services.Utility.Order = this.Order;
            MessageBox.Show("Saved");
        }
    }
}
