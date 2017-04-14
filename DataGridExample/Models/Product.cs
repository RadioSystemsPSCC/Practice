using System;
using System.ComponentModel;
using System.Windows.Input;
using DataGridCRUDExample.Services;

namespace DataGridCRUDExample.Models {
    public class Product : INotifyPropertyChanged {
        private string _name;
        public string Name {
            get { return _name; }
            set {
                if (_name != value) {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private string _sku;
        public string Sku {
            get { return _sku;}
            set {
                if (!string.Equals(_sku, value, StringComparison.InvariantCulture)) {
                    _sku = value;
                    OnPropertyChanged("Sku");
                }
            }
        }

        private double _price;
        public double Price {
            get { return _price; }
            set {
                if (_price != value) {
                    _price = value;
                    OnPropertyChanged("Price");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand _save;
        public ICommand Save {
            get {
                if (_save == null) {
                    _save = new SaveCommand(this);
                }
                return _save;
            }
        }

        protected void OnPropertyChanged(string name) {
            var handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class SaveCommand : ICommand {
        private Product _product;

        public SaveCommand(Product product) {
            _product = product;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            var webService = new WebApiService();
            webService.SaveProduct(_product);
        }

        public event EventHandler CanExecuteChanged;
    }
}
