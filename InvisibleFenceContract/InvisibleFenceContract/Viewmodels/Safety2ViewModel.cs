using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows;
using System.Data;
using InvisibleFenceContract.Services;

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
                return this._gPSPrice;
            }
            set
            {
                if (value != this._gPSPrice)

                {
                    this.GPSPrice = value;
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
                if (value != this._boundaryPlusPrice)
                    BoundaryPlusPrice = value;
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
                if (value != this._digitalTechnologyPrice)
                {
                    DigitalTechnologyPrice = value;
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
                if (value != this._packageSelection)
                {
                    this.PackageSelection = value;
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
                if (value != this._packagePrice)
                {
                    this.PackagePrice = value;
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
                if (value != this._safetyTotal)
                {
                    this.SafetyTotal = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }



    }
}
