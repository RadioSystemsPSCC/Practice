using System;
using System.Windows;
using System.Windows.Input;
using InvisibleFenceContract.Models;

namespace InvisibleFenceContract.Viewmodels.Commands {
    public class SelectCustomerCommand : ICommand {
        private Customer _selectCustomer;
        public event EventHandler CanExecuteChanged;

        public SelectCustomerCommand(Customer selectModel) {
            _selectCustomer = selectModel;
        }

        public bool CanExecute(Object parameter) {
            return true;
        }

        public void Execute(Object parameter) {
            Application.Current.Properties["Cus_ID"] = _selectCustomer.CustomerID;
            MessageBox.Show("Customer Selected");
        }
    }
}
