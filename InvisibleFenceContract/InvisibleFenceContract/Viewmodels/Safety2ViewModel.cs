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
                return this.GPSPrice;
            }
            set
            {
                if (value != this.GPSPrice)

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
                return "$" + this.BoundaryPlusPrice;
            }
            set
            {
                BoundaryPlusPrice = value;
                OnPropertyChanged("boundaryPlusPrice");
            }
        }

        public string DigitalTechnologyPrice
        {
            get
            {

                return "$" + DigitalTechnologyPrice;
            }

            set
            {
                DigitalTechnologyPrice = value;
                OnPropertyChanged("DigitalTechnologyPrice");
            }
        }

        public string PackageSelection
        {
            get
            {
                return this.PackageSelection;
            }
            set
            {
                if (value != this.PackageSelection)
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
                return "$" + this.PackagePrice;
            }
            set
            {
                if (value != this.PackagePrice)
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
                return "$" + PackagePrice;
            }
            set
            {
                if (value != this.SafetyTotal)
                {
                    this.SafetyTotal = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }



    }
}
