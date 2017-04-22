using System.Collections.Generic;
using InvisibleFenceContract.Models;

namespace InvisibleFenceContract.Viewmodels
{
    public class Safety2ViewModel : BindableBase
    {
        //order1 = (Order)Application.Current.Properties["myOrder"];
        private string _gPSPrice;
        private string _boundaryPlusPrice;
        private string _digitalTechnologyPrice;
        private string _packageSelection;
        private string _packagePrice;
        private string _safetyTotal;

        public Safety2ViewModel()
        {
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
        }
        public List<Product> safetyPrices
        {
            get;
            set;
        }

        public string GPSPrice
        {

            get
            {
                return "$" + this._gPSPrice;
            }
            set
            {
                if (value != this.GPSPrice)

                {
                    this._gPSPrice = value;
                    OnPropertyChanged("GPSPrice");
                }
            }
        }

        public string BoundaryPlusPrice
        {
            get
            {
                return "$" + this._boundaryPlusPrice;
            }
            set
            {
                if (value != this.BoundaryPlusPrice)
                    _boundaryPlusPrice = value;
                OnPropertyChanged("BoundaryPlusPrice");
            }
        }

        public string DigitalTechnologyPrice
        {
            get
            {

                return "$" + _digitalTechnologyPrice;
            }

            set
            {
                if (value != this.DigitalTechnologyPrice)
                {
                    _digitalTechnologyPrice = value;
                    OnPropertyChanged("DigitalTechnologyPrice");
                }            }
        }

        public string PackageSelection
        {
            get
            {
                return this._packageSelection;
            }
            set
            {
                if (value != this.PackageSelection)
                {
                    this._packageSelection = value;
                    OnPropertyChanged("PackageSelection");
                }
            }
        }

        public string PackagePrice
        {
            get
            {
                return "$" + this._packagePrice;
            }
            set
            {
                if (value != this.PackagePrice)
                {
                    this._packagePrice = value;
                    OnPropertyChanged("PackagePrice");
                }
            }
        }

        public string SafetyTotal
        {
            get
            {
                return "$" + this._safetyTotal;
            }
            set
            {
                if (value != this.SafetyTotal)
                {
                    this._safetyTotal = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }


    }
}
